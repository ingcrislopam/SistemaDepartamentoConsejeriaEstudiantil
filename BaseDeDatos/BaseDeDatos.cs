using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public class BaseDeDatos
    {
        private SqlConnection conexion = null;
        private SqlCommand comando = null;
        private SqlTransaction transaccion = null;
        private String cadenaConexion;

        public BaseDeDatos()
        {
            configurar();
        }

        private void configurar()
        {
            this.cadenaConexion = @"Data Source=FCUZME-PC\TECNICOFCUZME;Initial Catalog=SistemaColegioTecnico;Integrated Security=True";
        }

        public void conectar()
        {
            if (this.conexion != null && !this.conexion.State.Equals(ConnectionState.Closed))
            {
                throw new Exception("La conexión ya se encuentra abierta");
            }
            try
            {
                if (this.conexion == null)
                {
                    this.conexion = new SqlConnection();
                    this.conexion.ConnectionString = cadenaConexion;
                }
                this.conexion.Open();
            }
            catch (DataException ex)
            {
                throw new Exception("Error al conectarse con la base de datos", ex);
            }
        }

        public void desconectar()
        {
            if (this.conexion.State.Equals(ConnectionState.Open))
            {
                this.conexion.Close();
            }
        }

        public void previo(string strSql, params object[] parametros)
        {
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.StoredProcedure;
            this.comando.CommandText = strSql;
            if (this.transaccion != null)
            {
                this.comando.Transaction = this.transaccion;
            }
            SqlCommandBuilder.DeriveParameters(this.comando);
            if (parametros.Length > 0)
            {
                int contador = 0;
                foreach (object item in parametros)
                {
                    comando.Parameters[contador++].Value = item;
                }
            }

        }

        public void previo(string strSql)
        {
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = strSql;
            if (this.transaccion != null)
            {
                this.comando.Transaction = this.transaccion;
            }
        }

        public void ejecutar(string strSql)
        {
            previo(strSql);
            this.comando.ExecuteNonQuery();
        }

        public object ejecutarEscalar(string strsql)
        {
            previo(strsql);
            return this.comando.ExecuteScalar();
        }

        public object ejecutarEscalar(string strSql, params object[] parametros)
        {
            previo(strSql, parametros);
            return this.comando.ExecuteScalar();
        }

        public void ejecutar(string strSql, params object[] parametros)
        {
            previo(strSql, parametros);
            this.comando.ExecuteNonQuery();
        }

        public DataTable ejecutarDataTable(string strSql, params object[] parametros)
        {
            previo(strSql, parametros);
            DataSet ds = new DataSet();
            new SqlDataAdapter(this.comando).Fill(ds);
            return ds.Tables[0].Copy();

        }

        public DataTable ejecutarDataTable(string strSql)
        {
            previo(strSql);
            DataSet ds = new DataSet();
            new SqlDataAdapter(this.comando).Fill(ds);
            return ds.Tables[0].Copy();

        }

        public SqlDataReader ejecutarReader(string strSql, params object[] parametros)
        {
            previo(strSql, parametros);
            return this.comando.ExecuteReader();
        }

        public void comenzarTransaccion()
        {
            if (this.transaccion == null || this.transaccion.Connection == null)
            {
                this.transaccion = this.conexion.BeginTransaction();
            }
        }

        public void cancelarTransaccion()
        {
            if (this.transaccion != null)
            {
                this.transaccion.Rollback();
            }
        }

        public void confirmarTransaccion()
        {
            if (this.transaccion != null)
            {
                this.transaccion.Commit();
            }
        }
    }
}

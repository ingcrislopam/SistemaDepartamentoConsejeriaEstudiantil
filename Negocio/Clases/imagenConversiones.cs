using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Clases
{
    public class imagenConversiones
    {
        public byte[] ImagenABytes(Image Imagen)
        {
            byte[] arreglo = null;
            try
            {
                if ((Imagen != null))
                {
                    MemoryStream Bin = new MemoryStream();
                    Imagen.Save(Bin, System.Drawing.Imaging.ImageFormat.Jpeg);
                    arreglo = Bin.GetBuffer();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No convirtio a bytes por: " + ex.ToString());
            }
            return arreglo;
        }

        public string bytesAString(byte[] arreglo)
        {
            string salida = "";
            int x = 0;
            try
            {
                for (x = 0; x <= arreglo.Length - 1; x++)
                {
                    salida += arreglo[x].ToString() + ",";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No lo convertio a String por: " + ex.ToString());
            }
            return salida;
        }

        public Image BytesAImagen(byte[] Imagen)
        {
            try
            {
                if ((Imagen != null))
                {
                    MemoryStream Bin = new MemoryStream(Imagen);
                    Image Resultado = Image.FromStream(Bin);
                    return Resultado;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public byte[] consultaByte(string identificacion)
        {
            string resultado = "";
            int x = 0;
            byte[] arreglo = null;
            string[] arregloTexto = null;
            try
            {
                resultado = identificacion;
                arregloTexto = resultado.Split(',');
                arreglo = new byte[arregloTexto.Length];
                for (x = 0; x <= arregloTexto.Length - 1; x++)
                {
                    if (arregloTexto[x].Equals("") == false)
                    {
                        arreglo[x] = Convert.ToByte(arregloTexto[x]);
                    }
                }
            }
            catch (Exception)
            {
            }
            return arreglo;
        }
    }
}

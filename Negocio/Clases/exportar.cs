using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Clases
{
    public class exportar
    {
        public bool llenarExcel(DataGridView ElGrid)
        {
            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook exLibro = default(Microsoft.Office.Interop.Excel.Workbook);
            Microsoft.Office.Interop.Excel.Worksheet exHoja = default(Microsoft.Office.Interop.Excel.Worksheet);
            try
            {
                exLibro = exApp.Workbooks.Add();
                exHoja = exLibro.Worksheets.Add();
                int NCol = ElGrid.ColumnCount;
                int NRow = ElGrid.RowCount;

                for (int i = 1; i <= NCol; i++)
                {
                    exHoja.Cells.Item[1, i] = ElGrid.Columns[i - 1].Name.ToString();
                }

                for (int Fila = 0; Fila <= NRow - 1; Fila++)
                {

                    for (int Col = 0; Col <= NCol - 1; Col++)
                    {
                        exHoja.Cells.Item[Fila + 2, Col + 1] = ElGrid[Col, Fila].Value;
                    }
                }
                exHoja.Rows.Item[1].Font.Bold = 1;
                exHoja.Rows.Item[1].HorizontalAlignment = 3;
                exHoja.Columns.AutoFit();
                exApp.Application.Visible = true;
                exHoja = null;
                exLibro = null;
                exApp = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al exportar a Excel");
                return false;
            }
            return true;
        }
    }
}

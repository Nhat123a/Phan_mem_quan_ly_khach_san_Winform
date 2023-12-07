using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    class XuatExcel
    {
        public static void DichVu(BunifuCustomDataGrid g, string duongdan, string tenbang)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;

            // Set header text
            for (int i = 0; i < g.Columns.Count; i++)
            {
                obj.Cells[1, i + 1] = g.Columns[i].HeaderText;
            }

            // Set cell values
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            obj.Columns.AutoFit();

            // Save the workbook
            obj.ActiveWorkbook.SaveAs(duongdan, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            obj.ActiveWorkbook.Saved = true;
            obj.Quit();
        }
    }
}

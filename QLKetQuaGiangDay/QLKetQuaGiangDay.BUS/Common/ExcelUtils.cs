using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Spire.Xls;

namespace QLKetQuaGiangDay.BUS.Common
{
    public class ExcelUtils
    {
        public static int createExcelFile(string fileName, DataTable datatable)
        {
            Excel.Workbook workbook = new Excel.Workbook();
            Excel.Worksheet sheet = workbook.Worksheets[0];

            CellStyle headerStyle = workbook.Styles.Add("HeaderStyle");
            headerStyle.WrapText = true;
            headerStyle.VerticalAlignment = VerticalAlignType.Center;
            headerStyle.HorizontalAlignment = HorizontalAlignType.Center;

            for (int i = 0; i < datatable.Columns.Count; i++)
            {
                sheet.Range[1, i + 1].Value = datatable.Columns[i].ColumnName;
                sheet.Range[1, i + 1].Style = headerStyle;
            }

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                for (int j = 0; j < datatable.Columns.Count; j++)
                {
                    sheet.Range[i + 2, j + 1].Value = datatable.Rows[i][j].ToString();
                }
            }

            workbook.SaveToFile(fileName);
            return 1;
        }
    }
}

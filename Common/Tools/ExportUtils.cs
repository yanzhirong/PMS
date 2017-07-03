using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Tools
{
    public static class ExportUtils
    {

        public static bool DataTableToExcel(DataTable _dt, bool _isShowExcle)
        {
            if (_dt == null || _dt.Rows.Count <= 0)
            {
                if (_isShowExcle)
                {
                    MsgUtils.ShowInfoMsg("无数据！");
                }
                return true;
            }

            int rowNumber = _dt.Rows.Count;//不包括字段名
            int columnNumber = _dt.Columns.Count;
            int colIndex = 0;

            if (rowNumber == 0)
            {
                return false;
            }

            try
            {
                //建立Excel对象 
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                //excel.Application.Workbooks.Add(true);
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
                excel.Visible = _isShowExcle;
                //Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.Worksheets[1];
                Microsoft.Office.Interop.Excel.Range range;

                //生成字段名称 
                foreach (DataColumn col in _dt.Columns)
                {
                    colIndex++;
                    excel.Cells[1, colIndex] = col.ColumnName;
                }

                object[,] objData = new object[rowNumber, columnNumber];

                for (int r = 0; r < rowNumber; r++)
                {
                    for (int c = 0; c < columnNumber; c++)
                    {
                        objData[r, c] = _dt.Rows[r][c];
                    }
                    //Application.DoEvents();
                }

                // 写入Excel 
                range = worksheet.Range[excel.Cells[2, 1], excel.Cells[rowNumber + 1, columnNumber]];
                //range.NumberFormat = "@";//设置单元格为文本格式
                range.Value2 = objData;
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

    }
}

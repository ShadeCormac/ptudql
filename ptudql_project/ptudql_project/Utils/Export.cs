using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ptudql_project.Utils
{
    public class Export
    {
        private Application _xlApp = null;
        private Workbook _xlWorkbook = null;
        private Worksheet _xlworksheet = null;
        static private object misVal = System.Reflection.Missing.Value;
        protected void Init()
        {
            _xlApp = new Application();
            _xlWorkbook = _xlApp.Workbooks.Add(misVal);
            _xlworksheet = _xlWorkbook.Sheets.Item[1];
            
        }

        public void Cleanup()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(_xlworksheet);
            _xlWorkbook.Close();
            Marshal.ReleaseComObject(_xlWorkbook);
            _xlApp.Quit();
            Marshal.ReleaseComObject(_xlApp);
        }

        public void ExportAccounts(List<TaiKhoan> list)
        {
            Init();
            _xlworksheet.Cells[1, 1] = "Tên TK";
            _xlworksheet.Cells[1, 2] = "Mật khẩu";
            _xlworksheet.Cells[1, 3] = "PHân Quyền";
            for (int i = 0; i < list.Count - 1; i++)
            {
                _xlworksheet.Cells[i + 2, 1] = list[i].TenDangNhap;
                _xlworksheet.Cells[i + 2, 2] = list[i].MatKhau;
                _xlworksheet.Cells[i + 2, 3] = list[i].LoaiTK;
                
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _xlWorkbook.SaveAs(path + @"\TaiKhoan.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook
                , misVal, misVal, misVal, misVal, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                misVal, misVal, misVal, misVal, misVal);
            Cleanup();
        }

        public void ExportQuestions(List<CauHoi> list)
        {
            Init();
            _xlworksheet.Cells[1, 1] = "Nội dung";
            _xlworksheet.Cells[1, 2] = "Câu A";
            _xlworksheet.Cells[1, 3] = "Câu B";
            _xlworksheet.Cells[1, 4] = "Câu C";
            _xlworksheet.Cells[1, 5] = "Câu D";
            _xlworksheet.Cells[1, 6] = "Câu đúng";
            _xlworksheet.Cells[1, 7] = "Loại câu hỏi";
            for (int i = 0; i < list.Count - 1; i++)
            {
                _xlworksheet.Cells[i + 2, 1] = list[i].NoiDung;
                _xlworksheet.Cells[i + 2, 2] = list[i].CauA;
                _xlworksheet.Cells[i + 2, 3] = list[i].CauB;
                _xlworksheet.Cells[i + 2, 4] = list[i].CauC;
                _xlworksheet.Cells[i + 2, 5] = list[i].CauD;
                _xlworksheet.Cells[i + 2, 6] = list[i].CauTLDung.ToString();
                _xlworksheet.Cells[i + 2, 7] = (list[i].LoaiCauHoi == 1) ? "GV nhập" : "HV đề xuất";
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _xlWorkbook.SaveAs(path + @"\Cauhoi.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook
                , misVal, misVal, misVal, misVal, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                misVal, misVal, misVal, misVal, misVal);
            Cleanup();
        }
    }
}

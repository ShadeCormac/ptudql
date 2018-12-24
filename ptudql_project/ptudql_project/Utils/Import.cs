using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ptudql_project.Utils
{
    public class Import
    {
        private Application _xlApp = null;
        private Workbook _xlWorkbook = null;
        private Worksheet _xlworksheet = null;
        private Range _xlRange = null;
        int _row;
        int _col;
        public Import(string filePath)
        {
            _xlApp = new Application();
            _xlWorkbook = _xlApp.Workbooks.Open(filePath);
            _xlworksheet = _xlWorkbook.Sheets[1];
            _xlRange = _xlworksheet.UsedRange;
        }
        public List<CauHoi> importQuestions()
        {
            _row = _xlRange.Rows.Count;
            _col = _xlRange.Columns.Count;
            return Loop(_row, _col);
        }

        public List<TaiKhoan> importAccount()
        {
            _row = _xlRange.Rows.Count;
            _col = _xlRange.Columns.Count;
            return LoopAccount(_row, _col);
        }

        public void Cleanup()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(_xlRange);
            Marshal.ReleaseComObject(_xlworksheet);
            _xlWorkbook.Close();
            Marshal.ReleaseComObject(_xlWorkbook);
            _xlApp.Quit();
            Marshal.ReleaseComObject(_xlApp);
        }

        private List<TaiKhoan> LoopAccount(int row, int col)
        {
            TaiKhoan curAccount = null;

            List<TaiKhoan> list = new List<TaiKhoan>();
            for (int i = 2; i <= row; i++)
            {
                if (_xlRange[i, 3] != null && _xlRange.Cells[i, 3].Value2 != null)

                {
                    
                    curAccount = new TaiKhoan()
                    {
                        TenDangNhap = _xlRange.Cells[i, 1].Value2,
                        MatKhau = Crypto.hashPassword(_xlRange.Cells[i, 2].Value2.ToString()),
                        LoaiTK = int.Parse(_xlRange.Cells[i, 3].Value2.ToString())
                    };
                    list.Add(curAccount);
                }
            }
            return list;
        }

        private List<CauHoi> Loop(int row, int col)
        {
            CauHoi curQuest = null;
          
            List<CauHoi> list = new List<CauHoi>();
            for (int i = 2; i <= row; i++)
            {
                if (_xlRange[i, 6] != null && _xlRange.Cells[i,6].Value2 != null)
                {
                    if (_xlRange.Cells[i, 6].Value2.Length != 1)
                    {
                        continue;
                    }
                    curQuest = new CauHoi()
                    {
                        NoiDung = _xlRange.Cells[i, 1].Value2,
                        CauA = _xlRange.Cells[i, 2].Value2,
                        CauB = _xlRange.Cells[i, 3].Value2,
                        CauC = _xlRange.Cells[i, 4].Value2,
                        CauD = _xlRange.Cells[i, 5].Value2,
                        CauTLDung = char.Parse(_xlRange.Cells[i, 6].Value2),
                        LoaiCauHoi = 1,
                        DaDuyet = 1
                    };
                    list.Add(curQuest);
                }
            }
            return list;
        }
    }
}

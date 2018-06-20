using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTBVT.Common
{
   public class ReportObjectModel
    {
        public string TrangThai { get; set; }
        public string NoiDung { get; set; }
        public string NgayLap { get; set; }
        public int MaPhieuNhap { get; set; }
        public DateTime NgayDuyet { get; set; }
        public string MaKhoVT { get; set; }
        public string NguoiDuyet { get; set; }

        public string NguoiLap { get; set; }
        public string MaCTPN { get; set; }
        public decimal MaPhieuKT { get; set; }

        public string MaNCC { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTBVT.Model
{
    public class NhanVienModel
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }

        public DateTime? NgaySinh { get; set; }

        public string DiaChi { get; set; }

        public string ChucVu { get; set; }

        public string MaPXTD { get; set; }

        public string TenPXTD { get; set; }

        public string Email { get; set; }

        public string RoleID { get; set; }

        public string Password { get; set; }

        public string MoTa { get; set; }

        public string Avatar { get; set; }
    }
}

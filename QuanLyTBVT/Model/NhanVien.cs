namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [StringLength(50)]
        public string MaNV { get; set; }

        [StringLength(150)]
        public string TenNV { get; set; }

        public bool? GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(150)]
        public string ChucVu { get; set; }

        [StringLength(50)]
        public string PhongBan { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(50)]
        public string RoleID { get; set; }

        [StringLength(250)]
        public string Password { get; set; }

        [StringLength(250)]
        public string MoTa { get; set; }

        [StringLength(100)]
        public string Avatar { get; set; }
    }
}

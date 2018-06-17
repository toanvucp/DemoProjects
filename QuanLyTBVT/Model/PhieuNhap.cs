namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [Key]
        [StringLength(50)]
        public string MaPhieuNhap { get; set; }

        [StringLength(50)]
        public string MaNCC { get; set; }

        [StringLength(50)]
        public string MaKhoVT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string NguoiLap { get; set; }

        [StringLength(50)]
        public string NguoiDuyet { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDuyet { get; set; }

        [StringLength(250)]
        public string NoiDung { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        [StringLength(50)]
        public string MaPhieuKT { get; set; }

    }
}

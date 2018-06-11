namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuYC")]
    public partial class PhieuYC
    {
        [Key]
        [StringLength(50)]
        public string MaPhieuYC { get; set; }

        [StringLength(150)]
        public string TenPhieu { get; set; }

        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string NguoiLap { get; set; }

        public DateTime? NgayDuyet { get; set; }

        [StringLength(50)]
        public string NguoiDuyet { get; set; }

        public int? TrangThai { get; set; }

        [StringLength(50)]
        public string MaKhoVT { get; set; }
    }
}

namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuKT")]
    public partial class PhieuKT
    {
        [Key]
        [StringLength(50)]
        public string MaPhieuKT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string NguoiLap { get; set; }

        [StringLength(150)]
        public string NguoiThamGia { get; set; }

        [StringLength(50)]
        public string NguoiDuyet { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDuyet { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }
    }
}

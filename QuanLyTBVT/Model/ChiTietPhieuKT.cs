namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuKT")]
    public partial class ChiTietPhieuKT
    {
        [Key]
        [Column(Order = 0)]
        public int MaCTKT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaPhieuKT { get; set; }

        [StringLength(10)]
        public string MaVT { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        [StringLength(150)]
        public string PTKT { get; set; }

        public int? SoLuong { get; set; }

        public int? TrangThaiKT { get; set; }

        [StringLength(250)]
        public string MoTa { get; set; }
    }
}

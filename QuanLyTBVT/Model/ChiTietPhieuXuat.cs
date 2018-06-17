namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuXuat")]
    public partial class ChiTietPhieuXuat
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaPX { get; set; }

        [StringLength(50)]
        public string MaVT { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public int? SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [StringLength(250)]
        public string MoTa { get; set; }

        [StringLength(50)]
        public string TrangThaiVT { get; set; }
    }
}

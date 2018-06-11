namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhap")]
    public partial class ChiTietPhieuNhap
    {
        [Key]
        public int MaCTPN { get; set; }

        [StringLength(50)]
        public string MaPhieuNhap { get; set; }

        [StringLength(50)]
        public string MaVT { get; set; }

        [StringLength(50)]
        public string MaKhoVT { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        public int? TrangThai { get; set; }

        [StringLength(50)]
        public string MaNCC { get; set; }

        public int? SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [StringLength(250)]
        public string MoTa { get; set; }
    }
}

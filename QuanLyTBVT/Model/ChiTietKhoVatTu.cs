namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietKhoVatTu")]
    public partial class ChiTietKhoVatTu
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaKhoVT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaVT { get; set; }

        public int? SoLuongNhap { get; set; }

        public int? SoLuongXuat { get; set; }

        public int? SoLuongTon { get; set; }

        public int? TonDauKy { get; set; }

        [Column(TypeName = "money")]
        public decimal? TriGiaTonKho { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }
    }
}

namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VatTu")]
    public partial class VatTu
    {
        [Key]
        [StringLength(50)]
        public string MaVT { get; set; }

        [StringLength(250)]
        public string TenVT { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        [StringLength(50)]
        public string MaLoaiVT { get; set; }

        [StringLength(50)]
        public string MaNCC { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [StringLength(250)]
        public string MoTa { get; set; }
    }
}

namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiVatTu")]
    public partial class LoaiVatTu
    {
        [Key]
        [StringLength(50)]
        public string MaLoaiVT { get; set; }

        [StringLength(250)]
        public string TenLoaiVT { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }
    }
}

namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoVatTu")]
    public partial class KhoVatTu
    {
        [Key]
        [StringLength(50)]
        public string MaKhoVT { get; set; }

        [StringLength(250)]
        public string TenKhoVT { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }
    }
}

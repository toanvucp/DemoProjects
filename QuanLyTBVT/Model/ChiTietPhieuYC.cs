namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuYC")]
    public partial class ChiTietPhieuYC
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MaPhieuYC { get; set; }

        [StringLength(50)]
        public string MaVT { get; set; }


        public int? SoLuong { get; set; }

        [StringLength(250)]
        public string MoTa { get; set; }

    }
}

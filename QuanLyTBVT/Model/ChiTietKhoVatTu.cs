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
        public int ID { get; set; }

        [StringLength(50)]
        public string MaKhoVT { get; set; }

        [StringLength(50)]
        public string MaVT { get; set; }

        [StringLength(50)]
        public string SerialNumber { get; set; }

        [StringLength(50)]
        public string TinhTrangVT { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public int SoLuong { get; set; }
    }
}

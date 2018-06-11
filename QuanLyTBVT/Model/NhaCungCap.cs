namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [Key]
        [StringLength(50)]
        public string MaNCC { get; set; }

        [StringLength(250)]
        public string TenNCC { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string MST { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }
    }
}

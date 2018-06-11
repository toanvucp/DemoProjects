namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuXuat")]
    public partial class PhieuXuat
    {
        [Key]
        [StringLength(50)]
        public string MaPX { get; set; }

        [StringLength(50)]
        public string MaPXTD { get; set; }

        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string NguoiLap { get; set; }

        public DateTime? NgayDuyet { get; set; }

        [StringLength(50)]
        public string NguoiDuyet { get; set; }

        [StringLength(250)]
        public string NoiDung { get; set; }
    }
}

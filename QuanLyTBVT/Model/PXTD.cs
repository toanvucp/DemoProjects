namespace QuanLyTBVT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PXTD")]
    public partial class PXTD
    {
        [Key]
        [StringLength(50)]
        public string MaPXTD { get; set; }

        [StringLength(150)]
        public string TenPXTD { get; set; }

        [StringLength(50)]
        public string ParentID { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }
    }
}

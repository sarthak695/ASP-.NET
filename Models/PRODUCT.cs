namespace ASP.NET.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCT")]
    public partial class PRODUCT
    {
        public int ID { get; set; }

        public int? PRODUCTID { get; set; }

        [StringLength(50)]
        public string PRODUCTNAME { get; set; }

        public int? CATEGORYID { get; set; }

        [StringLength(50)]
        public string CATEGORYNAME { get; set; }
    }
}

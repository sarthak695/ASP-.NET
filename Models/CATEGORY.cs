namespace ASP.NET.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CATEGORY")]
    public partial class CATEGORY
    {
        public int id { get; set; }

        public int? CATEGORYID { get; set; }

        [StringLength(10)]
        public string CATEGORYNAME { get; set; }
    }
}

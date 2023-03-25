using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ASP.NET.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model2")
        {
        }

        public virtual DbSet<CATEGORY> CATEGORies { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CATEGORY>()
                .Property(e => e.CATEGORYNAME)
                .IsFixedLength();

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.PRODUCTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.CATEGORYNAME)
                .IsUnicode(false);
        }
    }
}

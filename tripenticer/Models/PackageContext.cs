namespace tripenticer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PackageContext : DbContext
    {
        public PackageContext()
            : base("name=PackageConnection")
        {
        }


        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
    }
}

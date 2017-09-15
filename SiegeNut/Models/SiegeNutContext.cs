using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiegeNut.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SiegeNut.Models
{
    public class SiegeNutContext : DbContext
    {
        public SiegeNutContext() : base("SiegeNutContext")
        {
        }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
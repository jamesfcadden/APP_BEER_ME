using APP_BEER_ME.Models;
using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APP_BEER_ME.DAL
{
    public class APP_BEER_MEContext : DbContext
    {
        public APP_BEER_MEContext() : base("APP_BEER_MEContext")
        {

        }

        public DbSet<Beer> Beers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Shop> Shops { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();            
        }

    }
}

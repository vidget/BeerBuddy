using BeerBuddy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BeerBuddy.Context
{
    public class BeerContext : DbContext
    {

        public BeerContext(): base ("BeerDBConnetionString")
        {
            Database.SetInitializer<BeerContext>(new DropCreateDatabaseAlways<BeerContext>());
        }

        public DbSet<Bar> Bars { get; set; }

        public DbSet<BarComment> BarComments { get; set; }

        public DbSet<Beer> Beers { get; set; }

        public DbSet<BeerComment> BeerComments { get; set; }

        public DbSet<SaleBeer> SaleBeers { get; set; }

    }
}
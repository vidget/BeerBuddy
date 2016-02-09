using BeerBuddy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerBuddy.Models
{
    public class BeerDbIntializer : System.Data.Entity.DropCreateDatabaseAlways<BeerContext>
    {
        protected override void Seed(BeerContext context)
        {
            context.Beers.Add(new Beer
            {
                BeerId = 1,
                BeerName ="Budweiser"

            });
            context.Beers.Add(new Beer
            {
                BeerId = 2,
                BeerName = "Miller"

            });
            context.Beers.Add(new Beer
            {
                BeerId = 3,
                BeerName = "Labatt"

            });
            context.Beers.Add(new Beer
            {
                BeerId = 4,
                BeerName = "Pabst"

            });
            context.Beers.Add(new Beer
            {
                BeerId = 5,
                BeerName = "Coors"

            });
            context.Beers.Add(new Beer
            {
                BeerId = 6,
                BeerName = "Bell's Oberon"

            });













            context.Bars.Add(new Bar 
            {
                BarId =0,
                BarName = "",
                Address = "",
                City ="",
                State ="",
                ZipCode = "",
                Phone ="",
                Rating = 0,
                UserId = 0
            });
            base.Seed(context);
        }

    }
}
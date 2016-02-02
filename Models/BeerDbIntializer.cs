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
                BeerId = 0,
                BeerName =""

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
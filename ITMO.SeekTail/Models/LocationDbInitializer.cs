using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.SeekTail.Models
{
    public class LocationDbInitializer : DropCreateDatabaseIfModelChanges <LocationContext>
    {
        protected override void Seed(LocationContext context)
        {
            context.Locations.Add(new Location
            {
                City = "Санкт-Петербург",
                Street = "Гаражный проспект",
                House = 4,
                LocationId = 1
            });
            base.Seed(context);
            context.Locations.Add(new Location
            {
                City = "Санкт-Петербург",
                LocationId = 2
            });
        }
    }
}
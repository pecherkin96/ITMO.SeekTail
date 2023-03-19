using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.SeekTail.Models
{
    public class ShelterContext : DbContext
    {
        public DbSet<Shelter> Shelters { get; set; }
        public System.Data.Entity.DbSet<ITMO.SeekTail.Models.Location> Locations { get; set; }
    }
}
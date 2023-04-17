using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ITMO.SeekTail.Models;

namespace ITMO.SeekTail.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<PetStatus> PetStatuses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PetColor> PetColors { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Shelter> Shelters { get; set; }

    }
}
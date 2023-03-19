using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.SeekTail.Models
{
    public class PetContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public System.Data.Entity.DbSet<ITMO.SeekTail.Models.Shelter> Shelters { get; set; }
    }
}
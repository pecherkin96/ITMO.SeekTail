using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.SeekTail.Models
{
    public class PetColorContext : DbContext
    {
        public DbSet<PetColor> PetColors { get; set; }
    }
}
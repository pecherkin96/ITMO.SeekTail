using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.SeekTail.Models
{
    public class AnimalContext : DbContext
    {
      public  DbSet<Animal> Animals { get; set; }
    }
}
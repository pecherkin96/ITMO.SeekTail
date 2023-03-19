using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.SeekTail.Models
{
    public class Shelter
    {
        public int ShelterId { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public string Image { get; set; }
        public long phone { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
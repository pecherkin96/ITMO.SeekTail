using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.SeekTail.Models
{
    public class Location
    {
       public int LocationId { get; set; }
       public string City { get; set; }
       public string Street { get; set; }
       public int House { get; set; }
       public int  Korpus { get; set; }
    }
}
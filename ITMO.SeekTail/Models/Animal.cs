using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMO.SeekTail.Models
{
    public class Animal 
    {
        [Key]
        public byte AnimalId { get; set; }
        [Display(Name = "Вид")]
        public string Type { get; set; }
    }
}
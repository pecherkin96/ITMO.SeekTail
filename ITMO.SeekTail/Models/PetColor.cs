using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMO.SeekTail.Models
{
    public class PetColor
    {
        [Key]
        public byte Id { get; set; }
        [Display(Name = "Цвет")]
        public string Color { get; set; }
    }
}
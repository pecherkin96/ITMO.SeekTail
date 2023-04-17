using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ITMO.SeekTail.Models
{
    public class Shelter
    {
        [Key]
        public int ShelterId { get; set; }
        [Display(Name = "Приют")]
        public string Name { get; set; }
        [Display(Name = "Картинка")]
        public string Image { get; set; }
        [Display(Name = "Телефон")]
        public long Phone { get; set; }
        public List<Pet> Pets { get; set; }
        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; }
    }
}
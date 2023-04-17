using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMO.SeekTail.Models
{
    public class PetStatus
    {
        [Key]
        public byte PetStatusId { get; set; }
        [Display(Name = "Статус")]
        public string Name { get; set; }

    }
}
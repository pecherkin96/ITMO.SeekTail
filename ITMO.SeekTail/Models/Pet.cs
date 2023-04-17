using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ITMO.SeekTail.Models
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }
        [Display(Name = "Имя животного")]
        public string Name { get; set; }
        [Display(Name = "Ссылка на Фото животного")]
        [Required(ErrorMessage = "Добавьте фото")]
        public string LinkImage { get; set; }
        public DateTime NoticeDate { get; set; }
        [Display(Name = "Описание животного")]
        [StringLength(300, MinimumLength = 0, ErrorMessage = "Описание должно быть в пределах до 300 символов")]
        public string Description { get; set; }
        public byte PetStatusId { get; set; }
        [ForeignKey("PetStatusId")]
        [Display(Name = "Статус")]
        public PetStatus PetStatus {get; set;}
        public int ShelterId { get; set; }
        [ForeignKey("ShelterId")]
        public  Shelter Shelter { get; set; }
        public byte PetColorId { get; set; }
        [ForeignKey("PetColorId")]
        public PetColor PetColor { get; set; }
        //вид животного
        public byte AnimalId { get; set; }
        [ForeignKey("AnimalId")]
        [Display(Name = "Вид животного")]
        public Animal Animal { get; set; }
    }
}
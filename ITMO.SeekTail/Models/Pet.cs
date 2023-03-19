using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.SeekTail.Models
{
    public class Pet
    {
        //первичный ключ
        public int PetId { get; set; }
        //вид животного
        public Animal AnimalId { get; set; }
        //Имя животного
        public string Name { get; set; }
        public PetColor ColorId { get; set; }
        //Сыылка на фото
        public string LinkImage { get; set; }
        //Описание животного
        public string Description { get; set; }
        public int ShelterId { get; set; }
        public virtual Shelter Shelter { get; set; }
    }
}
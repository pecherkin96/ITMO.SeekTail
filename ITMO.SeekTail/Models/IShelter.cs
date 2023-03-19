using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.SeekTail.Models
{
    public interface IShelter
    {
        List<Shelter> GetShelters();
        Shelter ShowPets(int id);
        void AddPet(Pet pet, Animal type);
        void AddShelter(Shelter shelter);
        void DeleteShelter(int id);
        List<Pet> SeeAllPets();
        List<Pet> FilterPets(string search);
    }
}
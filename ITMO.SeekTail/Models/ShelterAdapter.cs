using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITMO.SeekTail.Models;

namespace ITMO.SeekTail.Models
{
    public class ShelterAdapter : IShelter
    {
        public List<Shelter> GetShelters()
        {
            using (ShelterContext db = new ShelterContext())
            {
                List<Shelter> shelters = db.Shelters.Include("Pets").ToList();
                return shelters;
            }
        }

        public Shelter ShowPets(int id)
        {
            using (ShelterContext db = new ShelterContext())
            {
                Shelter ShelterPets = db.Shelters.Include("Pets").Where(x => x.ShelterId == id).FirstOrDefault();
                return ShelterPets;
            }
        }

        public void AddPet(Pet pet, Animal type)
        {
            using (PetContext db = new PetContext())
            {
                pet.AnimalId = type;
                db.Pets.Add(pet);
                db.SaveChanges();
            }
        }

        public void AddShelter(Shelter shelter)
        {
            using (ShelterContext db = new ShelterContext())
            {
                db.Shelters.Add(shelter);
                db.SaveChanges();
            }
        }

        public void DeleteShelter(int id)
        {
            using (ShelterContext dbshelter = new ShelterContext())
            {
                using (PetContext dbpet = new PetContext())
                {
                    while (dbpet.Pets.Where(x => x.ShelterId == id).Count() != 0)
                    {
                        Pet pet = dbpet.Pets.Where(x => x.ShelterId == id).FirstOrDefault();
                        dbpet.Pets.Remove(pet);
                        dbpet.SaveChanges();
                    }
                }
                Shelter shelter = dbshelter.Shelters.Find(id);
                dbshelter.Shelters.Remove(shelter);
                dbshelter.SaveChanges();
            }
        }

        public List<Pet> SeeAllPets()
        {
            using (PetContext db = new PetContext())
            {
                List<Pet> Pets = db.Pets.OrderBy(x => x.Name).ToList();
                return Pets;
            }
        }

        public List<Pet> FilterPets(string search)
        {
            List<Pet> Pets = new List<Pet>();
            using (PetContext db = new PetContext())
            {
                if (!string.IsNullOrWhiteSpace(search))
                {
                    string s = search.ToLower();
                    Pets = db.Pets.Where(p => p.AnimalId.ToString().ToLower().Contains(s) || p.Name.ToLower().Contains(s) || p.Description.ToLower().Contains(s)).ToList();
                }
                else
                {
                    Pets = db.Pets.ToList();
                }
            }
            return Pets;
        }
    }
}
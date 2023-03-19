using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.SeekTail.Models;

namespace ITMO.SeekTail.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShelter adapter;
        public HomeController()
        {
             adapter = new ShelterAdapter();
        }
        [HttpGet]
        public ActionResult SeeAllPets()
        {
            List<Pet> Pets = adapter.SeeAllPets();
            return View(Pets);
        }
        [HttpPost]
        public ActionResult SeeAllPets(string Search)
        {
            List<Pet> Pets = adapter.FilterPets(Search);
            return View(Pets);
        }
        [HttpGet]
        public ActionResult AddShelter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddShelter(Shelter shelter)
        {
            adapter.AddShelter(shelter);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ShelterDetails(int id)
        {
            Shelter ShelterPets = adapter.ShowPets(id);
            return View(ShelterPets);
        }
        public ActionResult DeleteShelter(int id)
        {
            adapter.DeleteShelter(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddPet(int id)
        {
            Pet pet = new Pet(); pet.ShelterId = id;
            return View(pet);
        }
        [HttpPost]
        public ActionResult AddPet(Pet pet, Animal type)
        {
            adapter.AddPet(pet, type);
            return RedirectToAction("ShelterDetails", new { Id = pet.ShelterId });
        }
        public ActionResult Index()
        {
            List<Shelter> Shelters = adapter.GetShelters();
            return View(Shelters);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
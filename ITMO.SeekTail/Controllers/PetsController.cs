using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ITMO.SeekTail.Data;
using ITMO.SeekTail.Models;

namespace ITMO.SeekTail.Controllers
{
    public class PetsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Pets
        public ActionResult Index()
        {
            return View(db.Pets.ToList());
        }
        public ActionResult Create()
        {
            SelectList colors = new SelectList(db.PetColors, "Id", "Color");
            SelectList animals = new SelectList(db.Animals, "AnimalId", "Type");
            SelectList statuses = new SelectList(db.PetStatuses, "PetStatusId", "Name");
            SelectList shelters = new SelectList(db.Shelters, "ShelterId", "Name");
            ViewBag.Colors = colors;
            ViewBag.Animals = animals;
            ViewBag.Statuses = statuses;
            ViewBag.Shelters = shelters;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                pet.NoticeDate = DateTime.Today;
                db.Pets.Add(pet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pet);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pet = db.Pets.Include("Animal").Include("Shelter").Include("PetStatus").Include("PetColor");
            var selected_pet = from p in pet
                               where p.PetId == id
                               select p;

            if (selected_pet == null)
            {
                return HttpNotFound();
            }
            return View(selected_pet);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            SelectList colors = new SelectList(db.PetColors, "Id", "Color");
            SelectList animals = new SelectList(db.Animals, "AnimalId", "Type");
            SelectList statuses = new SelectList(db.PetStatuses, "PetStatusId", "Name");
            SelectList shelters = new SelectList(db.Shelters, "ShelterId", "Name");
            ViewBag.Colors = colors;
            ViewBag.Animals = animals;
            ViewBag.Statuses = statuses;
            ViewBag.Shelters = shelters;
            return View(pet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pet pet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pet);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pet = db.Pets.Include("Animal").Include("Shelter").Include("PetStatus").Include("PetColor");
            var selected_pet = from p in pet
                               where p.PetId == id
                               select p;

            if (selected_pet == null)
            {
                return HttpNotFound();
            }
            return View(selected_pet);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pet pet = db.Pets.Find(id);
            db.Pets.Remove(pet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
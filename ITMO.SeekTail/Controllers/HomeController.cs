using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.SeekTail.Data;
using ITMO.SeekTail.Models;

namespace ITMO.SeekTail.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            var allPets = db.Pets.Include("Shelter").Include("Animal").OrderBy(n => n.Name).ToList();
            return View(allPets); ;
        }
    }
}
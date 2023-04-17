using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.SeekTail.Data;

namespace ITMO.SeekTail.Controllers
{
    public class SheltersController : Controller
    {
        private AppDbContext db = new AppDbContext();
        // GET: Shelters
        public ActionResult Index()
        {
            return View(db.Shelters.ToList());
        }
    }
}
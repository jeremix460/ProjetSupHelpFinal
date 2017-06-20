using ProjetSupHelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ProjetSupHelp.Controllers
{
    public class DemandController : Controller
    {
        // List all propositions
        [HttpGet]
        public ActionResult Index()
        {
            using (SupHelpDbContext db = new SupHelpDbContext())
            {
                return View(db.Demands.Include(sd => sd.DemandedCourses).Include(c => c.Campus).Include(av => av.Availabilities).ToList());
            }
        }

        
    }
}
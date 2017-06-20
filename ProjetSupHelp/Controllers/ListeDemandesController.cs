using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetSupHelp.Controllers
{
    public class ListeDemandesController : Controller
    {
        // GET: ListeDemandes
        public ActionResult Index()
        {
            return View();
        }
    }
}
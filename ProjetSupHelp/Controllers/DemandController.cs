using ProjetSupHelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Collections.Specialized;
using System.Diagnostics;

namespace ProjetSupHelp.Controllers
{
    [Authorize]
    public class DemandController : Controller
    {
        // List all Demands
        [HttpGet]
        public ActionResult Index()
        {
            using (SupHelpDbContext db = new SupHelpDbContext())
            {
                return View(db.Demands.Include(sd => sd.DemandedCourses).Include(c => c.Campus).Include(av => av.Availabilities).ToList());
            }
        }

        //Make a Demand
        [HttpGet]
        public ActionResult Demand()
        {
            return View();

        }

        //Supply the demand
        [HttpPost]
        public ActionResult Demand(SupportDemand demand)
        {
            //instance a new support demands
            SupportDemand newdemand = new SupportDemand()
            {
                Availabilities = new List<Availability>(),
                Campus = new List<Campus>(),
                DemandedCourses = new List<Course>()
            };

            //Retrieve all form attributes
            NameValueCollection demandForm = Request.Form;

            using (SupHelpDbContext db = new SupHelpDbContext())
            {
                // Parse SupInfo Demanded Courses
                if (!string.IsNullOrEmpty(demandForm["courses_list"]))
                {
                    string[] couses_list = demandForm["courses_list"].Split(new Char[] { ',' });
                    foreach (string course in couses_list)
                    {
                        int tmp_id = Int32.Parse(course);
                        var tmp_course = db.Courses.Where(u => u.Id == tmp_id).FirstOrDefault();
                        Debug.WriteLine("DEBUG :" + tmp_course.Label);
                        newdemand.DemandedCourses.Add(tmp_course);
                    }

                }

                // Parse SupInfo Demanded Courses
                if (!string.IsNullOrEmpty(demandForm["campus_list"]))
                {
                    string[] campus_list = demandForm["campus_list"].Split(new Char[] { ',' });
                    foreach (string campus in campus_list)
                    {
                        int tmp_id = Int32.Parse(campus);
                        var tmp_campus = db.Campus.Where(u => u.ID == tmp_id).FirstOrDefault();
                        Debug.WriteLine("DEBUG :" + tmp_campus.City);
                        newdemand.Campus.Add(tmp_campus);
                    }
                }

                //Parse Days Availibilities
                String[] AvailibilitiesArray;
                AvailibilitiesArray = Request.Form.GetValues("availibities");
                if (!(AvailibilitiesArray == null))
                {
                    foreach (string state in AvailibilitiesArray)
                    {
                        Debug.WriteLine("DEBUG :" + state);
                        newdemand.Availabilities.Add(new Availability()
                        {
                            Day = (DayOfWeek)Enum.ToObject(typeof(DayOfWeek), Int32.Parse(state))
                        });
                    }
                }

                //Add predifined model attributes
                newdemand.BoosterID = Int32.Parse(User.Identity.Name.Split('@')[0]);
                newdemand.CreationDate = DateTime.Now;
                newdemand.Comments = demand.Comments;
                

                //Push demand to DB
                db.Demands.Add(newdemand);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Details(int Id)
        {
            using (SupHelpDbContext db = new SupHelpDbContext())
            {
                var demand = db.Demands.Include(sp => sp.DemandedCourses).Include(c => c.Campus).Include(av => av.Availabilities).Where(prop => prop.ID == Id).FirstOrDefault();

                if (ModelState.IsValid)
                {
                    return View(demand);
                }
            }

            return RedirectToAction("Index");

        }

    }
}
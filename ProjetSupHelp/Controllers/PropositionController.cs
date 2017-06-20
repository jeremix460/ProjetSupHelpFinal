using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetSupHelp.Models;
using System.Diagnostics;
using System.Collections.Specialized;

namespace ProjetSupHelp.Controllers
{
    [Authorize]
    public class PropositionController : Controller
    {

        // List all propositions
        [HttpGet]
        public ActionResult Index()
        {
            using (SupHelpDbContext db = new SupHelpDbContext())
            {
                return View(db.Propositions.Include(sp => sp.SupportedCourses).Include(c => c.Campus).Include(av => av.Availabilities).ToList());
            }
        }

        //Make a proposition
        [HttpGet]
        public ActionResult Offer()
        {
            return View();

        }
        
        //Supply the proposition
        [HttpPost]
        public ActionResult Offer(SupportProposition proposition)
        {
            //instance a new support propositions
            SupportProposition newProposition = new SupportProposition()
            {
                Availabilities = new List<Availability>(),
                Campus = new List<Campus>(),
                SupportedCourses = new List<Course>()
            };

            //Retrieve all form attributes
            NameValueCollection propositionForm = Request.Form;

            using (SupHelpDbContext db = new SupHelpDbContext())
            {
                // Parse SupInfo Supported Courses
                if (!string.IsNullOrEmpty(propositionForm["courses_list"]))
                {
                    string[] couses_list = propositionForm["courses_list"].Split(new Char[] { ','});
                    foreach (string course in couses_list)
                    {
                        int tmp_id = Int32.Parse(course);
                        var tmp_course = db.Courses.Where(u => u.Id == tmp_id).FirstOrDefault();
                        Debug.WriteLine("DEBUG :" + tmp_course.Label);
                        newProposition.SupportedCourses.Add(tmp_course);
                    }

                }

                // Parse SupInfo Supported Courses
                if (!string.IsNullOrEmpty(propositionForm["campus_list"]))
                {
                    string[] campus_list = propositionForm["campus_list"].Split(new Char[] { ',' });
                    foreach (string campus in campus_list)
                    {
                        int tmp_id = Int32.Parse(campus);
                        var tmp_campus = db.Campus.Where(u => u.ID == tmp_id).FirstOrDefault();
                        Debug.WriteLine("DEBUG :" + tmp_campus.City);
                        newProposition.Campus.Add(tmp_campus);
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
                        newProposition.Availabilities.Add(new Availability()
                        {
                            Day = (DayOfWeek)Enum.ToObject(typeof(DayOfWeek), Int32.Parse(state))
                        });
                    }
                }
              
                //Add predifined model attributes
                newProposition.BoosterID = Int32.Parse(User.Identity.Name.Split('@')[0]);
                newProposition.CreationDate = DateTime.Now;
                newProposition.Comments = proposition.Comments;
                newProposition.ExtraCourses = proposition.ExtraCourses;
                    
                //Push Proposition to DB
                db.Propositions.Add(newProposition);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Details(int Id)
        {
            using (SupHelpDbContext db = new SupHelpDbContext())
            {
                var proposition = db.Propositions.Include(sp => sp.SupportedCourses).Include(c => c.Campus).Include(av => av.Availabilities).Where(prop => prop.ID == Id).FirstOrDefault();
                
                if (ModelState.IsValid)
                {
                    return View(proposition);
                }
            }

            return RedirectToAction("Index");

        }

    }

}
using PatientRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;




using System.Web.Providers.Entities;
namespace PatientRegistrationSystem.Controllers
{
    public class HomeController : Controller
    {


        //
        // GET: /Home/

        DB db = new DB();

        public ActionResult Index()
        {
            //var a = db.UserProfiles.ToList();
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(UserProfile userprof)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var temp = from r in db.UserProfiles where r.email == userprof.email select r.name;
        //        var list = temp.ToList();

        //        if (list.Count() == 0)
        //        {
        //            db.UserProfiles.Add(userprof);
        //            db.SaveChanges();
        //            HttpContext.Session["User"] = userprof.name;
        //            HttpContext.Session["Role"] = "User";
        //            return RedirectToAction("Userdetails", "Home", new { arg = userprof.email });
        //        }
        //        else
        //        {

        //            ModelState.AddModelError("email", "Email Id Already exists");
        //            return View();

        //        }
        //    }
        //    else
        //        return RedirectToAction("Error", "Home");

        //}

        //public ActionResult Gender()
        //{

        //    return View();
        //}

        //public ActionResult Error()
        //{

        //    return View();
        //}

        public ActionResult Register() {


            return PartialView("_Register");
        }


        [HttpPost]
        public ActionResult Register(Models.User Model) {

            db.Users.Add(Model);

            db.SaveChanges();
            return PartialView("_gender");

        }

        //public ActionResult FinalView(string arg)
        //{

        //    if (HttpContext.Session["user"] != null)
        //    {
        //        var model = (from r in db.UserDetails join z in db.UserProfiles on r.email equals z.email where r.email == arg && z.email == arg select new GpViewModel() { name = z.name, address = r.Address, email = r.email, DOB = r.DOB }).FirstOrDefault();
        //        if (model != null)
        //        {
        //            GpViewModel gp = new GpViewModel();
        //            gp.name = model.name;
        //            gp.address = model.address;
        //            gp.DOB = model.DOB;
        //            gp.email = model.email;
        //            return View(model);
        //        }
        //        else
        //        {

        //            return RedirectToAction("Error", "Home");

        //        }
        //    }
        //    else
        //    {
        //        return RedirectToAction("Login", "Accounts");
        //    }
        //}




        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}

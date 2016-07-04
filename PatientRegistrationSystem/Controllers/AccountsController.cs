using PatientRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatientRegistrationSystem.Controllers
{
    public class AccountsController : Controller
    {
        //
        // GET: /Accounts/

        DB db = new DB();

        [HttpGet]
        public ActionResult Index(string name = null)
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Index(Gpdetail Gpdet) {

            if (ModelState.IsValid)
            {
                var temp = from r in db.Gpdetails where r.email == Gpdet.email select r.name;
                var list = temp.ToList();

                if (list.Count() == 0)
                {
                    db.Gpdetails.Add(Gpdet);
                    db.SaveChanges();
                    HttpContext.Session["User"] = Gpdet.name;
                    HttpContext.Session["Role"] = "Admin";
                    HttpContext.Session["email"] = Gpdet.email;
                    return RedirectToAction("Gpview", "Accounts", new { arg = Gpdet.email });
                }
                else
                {

                    ModelState.AddModelError("email", "Email Id Already exists");
                    return View();

                }
            }
            else
                return RedirectToAction("Error", "Home");


            
        }

        [HttpGet]
        public ActionResult Login() {

            

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel userlogin)
        {

            var temp = from r in db.UserProfiles where r.email == userlogin.email && r.password == userlogin.password select r.name;
            var list = temp.ToList();
            if (list.Count() == 1)
            {

                HttpContext.Session["User"] = list[0].ToString();
                HttpContext.Session["Role"] = "User";
                HttpContext.Session["email"] = userlogin.email;
                return RedirectToAction("FinalView", "Home", new { arg = userlogin.email});

            }
            else
            {
                ModelState.AddModelError("password", "The Email Id and password doesn't match");
                return View();
            }
        }

        [HttpGet]
        public ActionResult GpLogin() { return View(); }


        [HttpPost]
        public ActionResult GpLogin(LoginModel GpLog) {

            var temp = from r in db.Gpdetails where r.email == GpLog.email && r.password == GpLog.password select r.name;
            var list = temp.ToList();
            if (list.Count() == 1)
            {

                HttpContext.Session["User"] = list[0].ToString();
                HttpContext.Session["Role"] = "Admin";
                HttpContext.Session["email"] = GpLog.email;
                return RedirectToAction("Gpview", "Accounts");

            }
            else
            {
                ModelState.AddModelError("password", "The Email Id and password doesn't match");
                return View();
            }
        
        }

        public ActionResult logout() {
            if (HttpContext.Session["User"] != null)
            {
                HttpContext.Session["User"] = null;
                HttpContext.Session["Role"] = null;
                return RedirectToAction("Index", "Home");
            }
            else { return RedirectToAction("Login", "Accounts"); }

        }

        public ActionResult Gpview(string arg) {
            if (HttpContext.Session["User"] != null)
            {
              var model = (from r in db.UserProfiles join z in db.UserDetails
                                 on r.email equals z.email 
                                 where z.Isconfirmed != true 
                                 select new GpViewModel() { id = z.UserDetail_id, name = r.name,email=r.email, DOB=z.DOB,address=z.Address,Isconfirmed = z.Isconfirmed }).ToList();
                
                return View(model);
            }
            else {

                return RedirectToAction("GpLogin", "Accounts");
            }
        }


        public ActionResult updatedate(string date, string time, string getit)
        {
            var dude = Int32.Parse(getit);
            var model = db.UserDetails.Find(dude);
            if (model != null)
            {

                model.prefdate = date;
                model.Time = time;
                model.Isconfirmed = true;
                model.Gpemail = HttpContext.Session["email"].ToString();
                db.SaveChanges();
                SMTP.sendMail(model.email);
                return RedirectToAction("Gpview", "Accounts");

            }
            else {

                return RedirectToAction("Error", "Home");
            
            }
        }

        public ActionResult Confirm() {


            return RedirectToAction("Gpview","Accounts");
        
        }


       

        public ActionResult Gpconsole() {

            if (HttpContext.Session["User"] != null)
            {
                var some = HttpContext.Session["email"].ToString();
                var model = (from r in db.UserProfiles
                             join z in db.UserDetails
                                 on r.email equals z.email
                             where z.Isconfirmed == true && z.Gpemail == some
                             select new GpViewModel() { id = z.UserDetail_id, name = r.name, email = r.email, DOB = z.DOB, address = z.Address, Isconfirmed = z.Isconfirmed, prefdate = z.prefdate, time= z.Time }).ToList();

                return View(model);
            }
            else
            {

                return RedirectToAction("GpLogin", "Accounts");
            }

            
        }



    }
}

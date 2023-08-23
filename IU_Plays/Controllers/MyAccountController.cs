using IU_Plays.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IU_Plays.Controllers
{
    public class MyAccountController : Controller
    {
        PlaysContext db=new PlaysContext();
        // GET: MyAccount
        public ActionResult Index()
        {
            return View(new login());
        }
        [HttpPost]
        public ActionResult Index(login user)
        {
            try
            {
                if (user.Email != null && user.Password != null)
                {
                    var Myuser = db.Users.First(x => x.Email == user.Email && x.Password == user.Password);
                    if (Myuser.Username != null)
                    {
                        
                        Session["id"] = Myuser.id;
                        Session["name"]= Myuser.Username;
                        return RedirectToAction("Home");
                    }
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    return View();
                }
            }
            catch(Exception x)
            {
                return View();
            }
        }
        public ActionResult Home()
        {
            return View();
        }
    }
}
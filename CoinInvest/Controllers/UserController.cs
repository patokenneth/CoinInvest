using CoinInvest.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CoinInvest.Controllers
{
    public class UserController : Controller
    {
        Create newcreation = new Create();
        // GET: User
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Dashboard()
        {

            return View();
        }

        public ActionResult Confirmation()
        {

            return View();
        }

        //[HttpPost]
        //public ActionResult Confirm()
        //{

        //    return RedirectToAction("Dashboard", "User");
        //}

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register1()
        {
            var userid = HttpContext.User.Identity.GetUserId();

            if (newcreation.CreateInvestor(userid))
            {
                return RedirectToAction("Confirmation", "User");
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Unable to make payment now");
        }
    }
}
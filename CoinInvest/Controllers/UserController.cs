﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoinInvest.Controllers
{
    public class UserController : Controller
    {
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
    }
}
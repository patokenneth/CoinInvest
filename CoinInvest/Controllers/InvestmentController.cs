using CoinInvest.DAL;
using CoinInvest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoinInvest.Controllers
{
    public class InvestmentController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Investment
        public ActionResult Index()
        {
            var items = db.Plans.ToList();

            return View(items);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public ActionResult Create(Plan model)
        {
            if (ModelState.IsValid)
            {
                db.Plans.Add(model);
                db.SaveChanges();

                return RedirectToAction("index", "Investment");
            }

            else
            {
                return View("create", model);
            }
            
            
        }

        public ActionResult Edit(int id)
        {
            if (id > 0)
            {
                var item = db.Plans.Where(x => x.ID == id).FirstOrDefault();
                return View(item);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Plan model)
        {
            var item = db.Plans.Where(x => x.ID == model.ID).FirstOrDefault();

            item.Amount = model.Amount;
            item.InvestmentName = model.InvestmentName;
            item.MaturityDuration = model.MaturityDuration;
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("index", "investment");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var item = db.Plans.Find(id);
            db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("index", "investment");
        }

        public ActionResult Invoice()
        {
            return View();
        }

        public ActionResult welcome()
        {
            return View();
        }
    }
}
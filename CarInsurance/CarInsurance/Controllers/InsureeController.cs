using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,ConvergeType")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();
            }
            if (ModelState.IsValid)
            {
                table.Quote = Convert.ToDecimal(QuoteGen(table.Id));
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,ConvergeType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult QuoteGen(int id)
        {
            Table table = db.Tables.Find(id);
            DateTime age = table.DateOfBirth;
            int year = table.CarYear;
            string make = table.CarMake;
            string model = table.CarModel;
            int ticket = table.SpeedingTickets;
            bool dui = table.DUI;
            bool full = table.ConvergeType;
            int quote = 50;
            if (age >= DateTime.Parse("01/01/2002 12:00:00 AM"))
            {
                quote = quote + 100;
            }
            else if (age >= DateTime.Parse("01/01/1995 12:00:00 AM"))
            {
                quote = quote + 50;
            }
            else
            {
                quote = quote + 25;
            }
            if (year < 2000)
            {
                quote = quote + 25;
            }
            else if (year > 2015)
            {
                quote = quote + 25;
            }
            if (make == "Porsche")
            {
                quote = quote + 25;
            }
            if (make == "Porsche" && model == "911 Carrera")
            {
                quote = quote + 25;
            }
            if (ticket >= 1)
            {
                int penalty = ticket * 10;
                quote = quote + penalty;
            }
            if (dui == true)
            {
                double penalty = quote * 1.25;
                quote = Convert.ToInt32(penalty);
            }
            if (full == true)
            {
                double coverage = quote * 1.5;
                quote = Convert.ToInt32(coverage);
            }
            return Content(Convert.ToString(quote));
            
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities1 db = new InsuranceEntities1();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }


        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {

                int insureeAge = DateTime.Now.Year - insuree.DateOfBirth.Year;

                insuree.Quote = this.GetQuote(insureeAge, insuree.CarYear, insuree.CarMake, insuree.CarModel, insuree.SpeedingTickets, insuree.DUI, insuree.CoverageType);

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }


        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        public decimal GetQuote(int age, int carYear, string carMake, string carModel, int speedingTickets, bool hasDUI, bool isFullCoverage)
        {
            decimal basePrice = 50m;

            // Age-based calculation using if statements
            if (age <= 18)
            {
                basePrice += 100m;
            }
            else if (age >= 19 && age <= 25)
            {
                basePrice += 50m;
            }
            else if (age >= 26)
            {
                basePrice += 25m;
            }

            // Car year calculation
            if (carYear < 2000 || carYear > 2015)
            {
                basePrice += 25m;
            }

            // Car make and model calculation
            if (carMake.Equals("Porsche", StringComparison.OrdinalIgnoreCase))
            {
                basePrice += 25m;

                if (carModel.Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
                {
                    basePrice += 25m; // Additional charge for Porsche 911 Carrera
                }
            }

            // Speeding tickets calculation
            if (speedingTickets > 0)
            {
                basePrice += speedingTickets * 10m;
            }

            // DUI calculation
            if (hasDUI)
            {
                basePrice *= 1.25m; // Adds 25% to total
            }

            // Full coverage calculation
            if (isFullCoverage)
            {
                basePrice *= 1.50m; // Adds 50% to total
            }

            // Return only the quote amount as a plain number
            return basePrice; // Formats to 2 decimal places
        }




    }
}

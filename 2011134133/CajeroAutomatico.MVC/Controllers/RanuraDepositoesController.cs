using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CajeroAutomatico.Entities;
using CajeroAutomatico.Persistance;

namespace CajeroAutomatico.MVC.Controllers
{
    public class RanuraDepositoesController : Controller
    {
        private CajeroDBContext db = new CajeroDBContext();

        // GET: RanuraDepositoes
        public ActionResult Index()
        {
            var ranuraDeposito = db.RanuraDeposito.Include(r => r.ATM);
            return View(ranuraDeposito.ToList());
        }

        // GET: RanuraDepositoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RanuraDeposito ranuraDeposito = db.RanuraDeposito.Find(id);
            if (ranuraDeposito == null)
            {
                return HttpNotFound();
            }
            return View(ranuraDeposito);
        }

        // GET: RanuraDepositoes/Create
        public ActionResult Create()
        {
            ViewBag.idATM = new SelectList(db.ATM, "idATM", "Direccion");
            return View();
        }

        // POST: RanuraDepositoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idRanuraDeposito,idATM")] RanuraDeposito ranuraDeposito)
        {
            if (ModelState.IsValid)
            {
                db.RanuraDeposito.Add(ranuraDeposito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idATM = new SelectList(db.ATM, "idATM", "Direccion", ranuraDeposito.idATM);
            return View(ranuraDeposito);
        }

        // GET: RanuraDepositoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RanuraDeposito ranuraDeposito = db.RanuraDeposito.Find(id);
            if (ranuraDeposito == null)
            {
                return HttpNotFound();
            }
            ViewBag.idATM = new SelectList(db.ATM, "idATM", "Direccion", ranuraDeposito.idATM);
            return View(ranuraDeposito);
        }

        // POST: RanuraDepositoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idRanuraDeposito,idATM")] RanuraDeposito ranuraDeposito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ranuraDeposito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idATM = new SelectList(db.ATM, "idATM", "Direccion", ranuraDeposito.idATM);
            return View(ranuraDeposito);
        }

        // GET: RanuraDepositoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RanuraDeposito ranuraDeposito = db.RanuraDeposito.Find(id);
            if (ranuraDeposito == null)
            {
                return HttpNotFound();
            }
            return View(ranuraDeposito);
        }

        // POST: RanuraDepositoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RanuraDeposito ranuraDeposito = db.RanuraDeposito.Find(id);
            db.RanuraDeposito.Remove(ranuraDeposito);
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
    }
}

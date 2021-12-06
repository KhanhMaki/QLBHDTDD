using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLBHDTDD.Models;

namespace QLBHDTDD.Controllers
{
    [AllowAnonymous]
    public class Danhmuc_spController : Controller
    {
        private DBconnect db = new DBconnect();

        // GET: Danhmuc_sp
        public ActionResult Index()
        {
            return View(db.Danhmuc_Sps.ToList());
        }

        // GET: Danhmuc_sp/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuc_sp danhmuc_sp = db.Danhmuc_Sps.Find(id);
            if (danhmuc_sp == null)
            {
                return HttpNotFound();
            }
            return View(danhmuc_sp);
        }

        // GET: Danhmuc_sp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Danhmuc_sp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_dm,Ten_danhmuc")] Danhmuc_sp danhmuc_sp)
        {
            if (ModelState.IsValid)
            {
                db.Danhmuc_Sps.Add(danhmuc_sp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danhmuc_sp);
        }

        // GET: Danhmuc_sp/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuc_sp danhmuc_sp = db.Danhmuc_Sps.Find(id);
            if (danhmuc_sp == null)
            {
                return HttpNotFound();
            }
            return View(danhmuc_sp);
        }

        // POST: Danhmuc_sp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_dm,Ten_danhmuc")] Danhmuc_sp danhmuc_sp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhmuc_sp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danhmuc_sp);
        }

        // GET: Danhmuc_sp/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuc_sp danhmuc_sp = db.Danhmuc_Sps.Find(id);
            if (danhmuc_sp == null)
            {
                return HttpNotFound();
            }
            return View(danhmuc_sp);
        }

        // POST: Danhmuc_sp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Danhmuc_sp danhmuc_sp = db.Danhmuc_Sps.Find(id);
            db.Danhmuc_Sps.Remove(danhmuc_sp);
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

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
    public class Tinh_trangController : Controller
    {
        private DBconnect db = new DBconnect();

        // GET: Tinh_trang
        public ActionResult Index()
        {
            return View(db.Tinh_Trangs.ToList());
        }

        // GET: Tinh_trang/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tinh_trang tinh_trang = db.Tinh_Trangs.Find(id);
            if (tinh_trang == null)
            {
                return HttpNotFound();
            }
            return View(tinh_trang);
        }

        // GET: Tinh_trang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tinh_trang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_tinh_trang,Tinhtrang")] Tinh_trang tinh_trang)
        {
            if (ModelState.IsValid)
            {
                db.Tinh_Trangs.Add(tinh_trang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tinh_trang);
        }

        // GET: Tinh_trang/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tinh_trang tinh_trang = db.Tinh_Trangs.Find(id);
            if (tinh_trang == null)
            {
                return HttpNotFound();
            }
            return View(tinh_trang);
        }

        // POST: Tinh_trang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_tinh_trang,Tinhtrang")] Tinh_trang tinh_trang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tinh_trang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tinh_trang);
        }

        // GET: Tinh_trang/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tinh_trang tinh_trang = db.Tinh_Trangs.Find(id);
            if (tinh_trang == null)
            {
                return HttpNotFound();
            }
            return View(tinh_trang);
        }

        // POST: Tinh_trang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tinh_trang tinh_trang = db.Tinh_Trangs.Find(id);
            db.Tinh_Trangs.Remove(tinh_trang);
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

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
    public class DanhgiasController : Controller
    {
        private DBconnect db = new DBconnect();

        // GET: Danhgias
        public ActionResult Index()
        {
            var danhgias = db.Danhgias.Include(d => d.SanPhams);
            return View(danhgias.ToList());
        }

        // GET: Danhgias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhgia danhgia = db.Danhgias.Find(id);
            if (danhgia == null)
            {
                return HttpNotFound();
            }
            return View(danhgia);
        }

        // GET: Danhgias/Create
        public ActionResult Create()
        {
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm");
            return View();
        }

        // POST: Danhgias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_dg,ID_sp,Ho_ten,Ngay_gio,Noi_dung,Dien_thoai")] Danhgia danhgia)
        {
            if (ModelState.IsValid)
            {
                db.Danhgias.Add(danhgia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", danhgia.ID_sp);
            return View(danhgia);
        }

        // GET: Danhgias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhgia danhgia = db.Danhgias.Find(id);
            if (danhgia == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", danhgia.ID_sp);
            return View(danhgia);
        }

        // POST: Danhgias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_dg,ID_sp,Ho_ten,Ngay_gio,Noi_dung,Dien_thoai")] Danhgia danhgia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhgia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", danhgia.ID_sp);
            return View(danhgia);
        }

        // GET: Danhgias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhgia danhgia = db.Danhgias.Find(id);
            if (danhgia == null)
            {
                return HttpNotFound();
            }
            return View(danhgia);
        }

        // POST: Danhgias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Danhgia danhgia = db.Danhgias.Find(id);
            db.Danhgias.Remove(danhgia);
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

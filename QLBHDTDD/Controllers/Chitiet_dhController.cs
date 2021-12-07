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
    [Authorize]
    public class Chitiet_dhController : Controller
    {
        private DBconnect db = new DBconnect();
        // GET: Chitiet_dh
        public ActionResult Index()
        {
            var chitiet_Dhs = db.Chitiet_Dhs.Include(c => c.Don_dhs).Include(c => c.SanPhams);
            return View(chitiet_Dhs.ToList());
        }
        // GET: Chitiet_dh/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitiet_dh chitiet_dh = db.Chitiet_Dhs.Find(id);
            if (chitiet_dh == null)
            {
                return HttpNotFound();
            }
            return View(chitiet_dh);
        }

        // GET: Chitiet_dh/Create
        public ActionResult Create()
        {
            ViewBag.ID_hd = new SelectList(db.Don_Dhs, "ID_hd", "Noi_nhan");
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm");
            return View();
        }

        // POST: Chitiet_dh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ct_hd,ID_hd,ID_sp,So_luong_mua,Don_gia")] Chitiet_dh chitiet_dh)
        {
            if (ModelState.IsValid)
            {
                db.Chitiet_Dhs.Add(chitiet_dh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_hd = new SelectList(db.Don_Dhs, "ID_hd", "Noi_nhan", chitiet_dh.ID_hd);
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", chitiet_dh.ID_sp);
            return View(chitiet_dh);
        }
        // GET: Chitiet_dh/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitiet_dh chitiet_dh = db.Chitiet_Dhs.Find(id);
            if (chitiet_dh == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_hd = new SelectList(db.Don_Dhs, "ID_hd", "Noi_nhan", chitiet_dh.ID_hd);
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", chitiet_dh.ID_sp);
            return View(chitiet_dh);
        }

        // POST: Chitiet_dh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ct_hd,ID_hd,ID_sp,So_luong_mua,Don_gia")] Chitiet_dh chitiet_dh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chitiet_dh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_hd = new SelectList(db.Don_Dhs, "ID_hd", "Noi_nhan", chitiet_dh.ID_hd);
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", chitiet_dh.ID_sp);
            return View(chitiet_dh);
        }

        // GET: Chitiet_dh/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitiet_dh chitiet_dh = db.Chitiet_Dhs.Find(id);
            if (chitiet_dh == null)
            {
                return HttpNotFound();
            }
            return View(chitiet_dh);
        }

        // POST: Chitiet_dh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Chitiet_dh chitiet_dh = db.Chitiet_Dhs.Find(id);
            db.Chitiet_Dhs.Remove(chitiet_dh);
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

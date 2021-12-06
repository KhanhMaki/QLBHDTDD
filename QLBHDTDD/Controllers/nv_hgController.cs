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
    public class nv_hgController : Controller
    {
        private DBconnect db = new DBconnect();

        // GET: nv_hg
        public ActionResult Index()
        {
            return View(db.nv_hgs.ToList());
        }

        // GET: nv_hg/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nv_hg nv_hg = db.nv_hgs.Find(id);
            if (nv_hg == null)
            {
                return HttpNotFound();
            }
            return View(nv_hg);
        }

        // GET: nv_hg/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: nv_hg/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_nvgh,Ten_nvgh,Sdt_1,Sdt_2")] nv_hg nv_hg)
        {
            if (ModelState.IsValid)
            {
                db.nv_hgs.Add(nv_hg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nv_hg);
        }

        // GET: nv_hg/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nv_hg nv_hg = db.nv_hgs.Find(id);
            if (nv_hg == null)
            {
                return HttpNotFound();
            }
            return View(nv_hg);
        }

        // POST: nv_hg/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_nvgh,Ten_nvgh,Sdt_1,Sdt_2")] nv_hg nv_hg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nv_hg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nv_hg);
        }

        // GET: nv_hg/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nv_hg nv_hg = db.nv_hgs.Find(id);
            if (nv_hg == null)
            {
                return HttpNotFound();
            }
            return View(nv_hg);
        }

        // POST: nv_hg/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            nv_hg nv_hg = db.nv_hgs.Find(id);
            db.nv_hgs.Remove(nv_hg);
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

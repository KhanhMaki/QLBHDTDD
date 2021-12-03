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
    public class Sp_banController : Controller
    {
        private DBconnect db = new DBconnect();

        // GET: Sp_ban
        public ActionResult Index()
        {
            var sp_Bans = db.Sp_Bans.Include(s => s.SanPhams);
            return View(sp_Bans.ToList());
        }

        // GET: Sp_ban/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sp_ban sp_ban = db.Sp_Bans.Find(id);
            if (sp_ban == null)
            {
                return HttpNotFound();
            }
            return View(sp_ban);
        }

        // GET: Sp_ban/Create
        public ActionResult Create()
        {
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm");
            return View();
        }

        // POST: Sp_ban/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_sp_ban,ID_sp,So_luong_ban")] Sp_ban sp_ban)
        {
            if (ModelState.IsValid)
            {
                db.Sp_Bans.Add(sp_ban);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", sp_ban.ID_sp);
            return View(sp_ban);
        }

        // GET: Sp_ban/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sp_ban sp_ban = db.Sp_Bans.Find(id);
            if (sp_ban == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", sp_ban.ID_sp);
            return View(sp_ban);
        }

        // POST: Sp_ban/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_sp_ban,ID_sp,So_luong_ban")] Sp_ban sp_ban)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sp_ban).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_sp = new SelectList(db.SanPhams, "ID_sp", "ID_dm", sp_ban.ID_sp);
            return View(sp_ban);
        }

        // GET: Sp_ban/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sp_ban sp_ban = db.Sp_Bans.Find(id);
            if (sp_ban == null)
            {
                return HttpNotFound();
            }
            return View(sp_ban);
        }

        // POST: Sp_ban/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sp_ban sp_ban = db.Sp_Bans.Find(id);
            db.Sp_Bans.Remove(sp_ban);
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

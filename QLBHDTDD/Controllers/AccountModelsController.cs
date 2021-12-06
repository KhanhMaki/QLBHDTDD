using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using QLBHDTDD.Models;

namespace QLBHDTDD.Controllers
{
    public class AccountModelsController : Controller
    {
        private DBconnect db = new DBconnect();

        // GET: AccountModels
        public ActionResult Index()
        {
            return View(db.AccountModels.ToList());
        }

        public ViewResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountModel acc, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (acc.Username == "admin" && acc.Password == "Abc1234")
                {
                    FormsAuthentication.SetAuthCookie(acc.Username, true);
                    return RedirectToLocal(returnUrl);
                }
            }
            return View(acc);
        }
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        // GET: AccountModels/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountModel accountModel = db.AccountModels.Find(id);
            if (accountModel == null)
            {
                return HttpNotFound();
            }
            return View(accountModel);
        }

        // GET: AccountModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Username,Password")] AccountModel accountModel)
        {
            if (ModelState.IsValid)
            {
                db.AccountModels.Add(accountModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountModel);
        }

        // GET: AccountModels/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountModel accountModel = db.AccountModels.Find(id);
            if (accountModel == null)
            {
                return HttpNotFound();
            }
            return View(accountModel);
        }

        // POST: AccountModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Username,Password")] AccountModel accountModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accountModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accountModel);
        }

        // GET: AccountModels/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountModel accountModel = db.AccountModels.Find(id);
            if (accountModel == null)
            {
                return HttpNotFound();
            }
            return View(accountModel);
        }

        // POST: AccountModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AccountModel accountModel = db.AccountModels.Find(id);
            db.AccountModels.Remove(accountModel);
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

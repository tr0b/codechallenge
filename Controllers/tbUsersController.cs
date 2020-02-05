﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using codechallenge.DAL;
using codechallenge.Models;

namespace codechallenge.Controllers
{
    public class tbUsersController : Controller
    {
        private UserProjectContext db = new UserProjectContext();

        // GET: tbUsers
        public ActionResult Index()
        {
            return View(db.tbUser.ToList());
        }

        // GET: tbUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbUser tbUser = db.tbUser.Find(id);
            if (tbUser == null)
            {
                return HttpNotFound();
            }
            return View(tbUser);
        }

        // GET: tbUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PK_UserID,First_Name,Last_Name")] tbUser tbUser)
        {
            if (ModelState.IsValid)
            {
                db.tbUser.Add(tbUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbUser);
        }

        // GET: tbUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbUser tbUser = db.tbUser.Find(id);
            if (tbUser == null)
            {
                return HttpNotFound();
            }
            return View(tbUser);
        }

        // POST: tbUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PK_UserID,First_Name,Last_Name")] tbUser tbUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbUser);
        }

        // GET: tbUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbUser tbUser = db.tbUser.Find(id);
            if (tbUser == null)
            {
                return HttpNotFound();
            }
            return View(tbUser);
        }

        // POST: tbUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbUser tbUser = db.tbUser.Find(id);
            db.tbUser.Remove(tbUser);
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

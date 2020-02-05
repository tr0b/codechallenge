using System;
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
    public class tbProjectsController : Controller
    {
        private UserProjectContext db = new UserProjectContext();

        // GET: tbProjects
        public ActionResult Index()
        {
            return View(db.tbProject.ToList());
        }

        // GET: tbProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProject tbProject = db.tbProject.Find(id);
            if (tbProject == null)
            {
                return HttpNotFound();
            }
            return View(tbProject);
        }

        // GET: tbProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbProjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PK_ProjectID,StartDate,EndDate,Credits")] tbProject tbProject)
        {
            if (ModelState.IsValid)
            {
                db.tbProject.Add(tbProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbProject);
        }

        // GET: tbProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProject tbProject = db.tbProject.Find(id);
            if (tbProject == null)
            {
                return HttpNotFound();
            }
            return View(tbProject);
        }

        // POST: tbProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PK_ProjectID,StartDate,EndDate,Credits")] tbProject tbProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbProject);
        }

        // GET: tbProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProject tbProject = db.tbProject.Find(id);
            if (tbProject == null)
            {
                return HttpNotFound();
            }
            return View(tbProject);
        }

        // POST: tbProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbProject tbProject = db.tbProject.Find(id);
            db.tbProject.Remove(tbProject);
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

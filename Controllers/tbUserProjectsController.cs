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
    public class tbUserProjectsController : Controller
    {
        private UserProjectContext db = new UserProjectContext();

        // GET: tbUserProjects
        public ActionResult Index()
        {
            tbUserProject usuproject = new tbUserProject();
            
            return View(db.tbUserProject.ToList());
        }

        // GET: tbUserProjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbUserProject tbUserProject = db.tbUserProject.Find(id);
            if (tbUserProject == null)
            {
                return HttpNotFound();
            }
            return View(tbUserProject);
        }

        // GET: tbUserProjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbUserProjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PK_UserProject,FK_UserID,FK_ProjectID,isActive,AssignedDate")] tbUserProject tbUserProject)
        {
            if (ModelState.IsValid)
            {
                db.tbUserProject.Add(tbUserProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbUserProject);
        }

        // GET: tbUserProjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbUserProject tbUserProject = db.tbUserProject.Find(id);
            if (tbUserProject == null)
            {
                return HttpNotFound();
            }
            return View(tbUserProject);
        }

        // POST: tbUserProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PK_UserProject,FK_UserID,FK_ProjectID,isActive,AssignedDate")] tbUserProject tbUserProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbUserProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbUserProject);
        }

        // GET: tbUserProjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbUserProject tbUserProject = db.tbUserProject.Find(id);
            if (tbUserProject == null)
            {
                return HttpNotFound();
            }
            return View(tbUserProject);
        }

        // POST: tbUserProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbUserProject tbUserProject = db.tbUserProject.Find(id);
            db.tbUserProject.Remove(tbUserProject);
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

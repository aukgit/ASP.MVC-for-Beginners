using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleMVCApp.Models;

namespace SimpleMVCApp.Controllers {
    public class PeopleController : Controller {
        private ContextEntities db = new ContextEntities();
        // GET: People
        public ActionResult Index() {
            var people = db.People.ToList();
            //Select * from People
            return View(people);
        }

        // GET: People/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: People/Create
        public ActionResult Create() {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        public ActionResult Create(Person person) {
            //var firstname = Request["Firstname"];

            try {
                if (ModelState.IsValid) {
                    db.People.Add(person);
                    db.SaveChanges();// insert into 
                    return RedirectToAction("Index");

                }

            } catch {
                throw new Exception("We can't create data.");

            }

            return View(person);
        }

        // GET: People/Edit/5
        public ActionResult Edit(int id) {
            var person = db.People.Find(id);// Select top 1  * from People where PersonID = id

            return View(person);
        }

        // POST: People/Edit/5
        [HttpPost]
        public ActionResult Edit(Person person) {
            try {
                if (ModelState.IsValid) {
                    db.Entry(person).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges(); // update
                    return RedirectToAction("Index");

                }
            } catch {
                throw new Exception("We can't save the modified data.");

            }
            return View(person);

        }

        // GET: People/Delete/5
        public ActionResult Delete(int id) {
            var person = db.People.Find(id);// Select top 1  * from People where PersonID = id

            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost]
        public ActionResult Delete(Person person) {
            try {
                //if (ModelState.IsValid) {
                person = db.People.Find(person.PersonID);// Select top 1  * from People where PersonID = id

                db.Entry(person).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges(); // delete
                return RedirectToAction("Index");
                //}

            } catch {
                throw new Exception("We can't remove data.");

            }
            


        }
    }
}

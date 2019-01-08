using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBook.Controllers
{
    public class GroupController : Controller
    {
        ContactContext db = new ContactContext();
        // GET: Group
        public ActionResult List()
        {
            IEnumerable<Groups> groups = db.Groups;
            return View(groups); 
        }

        public ActionResult Additional()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Additional(Groups group)
        {
            if (!ModelState.IsValid)
                return View(group);

            db.Groups.Add(group);
            db.SaveChanges();
            return RedirectToAction("List");            
        }

        public ActionResult Delete(int? id)
        {
            Groups group = db.Groups.Find(id);

            if (group != null)
            {
                db.Groups.Remove(group);
                db.SaveChanges();
            }

            return RedirectToAction("List");

        }
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(int? Id, Groups model)
        {

            Groups group = db.Groups.Find(Id);
            db.Groups.Remove(group);
            db.Groups.Add(model);

            db.SaveChanges();

            return RedirectToAction("List");

        }

    }
}
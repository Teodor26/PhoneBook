using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBook.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactContext db = new ContactContext();


        public ActionResult Index()
        {
            IEnumerable<Contact> contacts = db.Contacts;
            return View(contacts);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Add(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            Contact contact = db.Contacts.Find(id);

            if(contact != null)
            {
                db.Contacts.Remove(contact);
                db.SaveChanges();
            }
           
            return RedirectToAction("Index");

        }

        
    }
}
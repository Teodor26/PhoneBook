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
        public ActionResult Index()
        {
            return View();
        }

    }
}
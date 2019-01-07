﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhoneBook.Models
{
    public class ContactDbInitializer : DropCreateDatabaseAlways<ContactContext>
    {

        protected override void Seed(ContactContext db)
        {
            db.Contacts.Add(new Contact { FirstName = "Alex", LastName = "Medved", Position = "student" });
            db.Contacts.Add(new Contact { FirstName = "John", LastName = "Smith", Position = "cook" });
            db.Contacts.Add(new Contact { FirstName = "Jack", LastName = "Williams", Position = "Senior developer" });
            

            base.Seed(db);
        }
    }
}
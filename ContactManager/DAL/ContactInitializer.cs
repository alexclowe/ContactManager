using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContactManager.Models;

namespace ContactManager.DAL
{
    public class ContactInitializer : DropCreateDatabaseIfModelChanges<ContactContext>
    {
        protected override void Seed(ContactContext context)
        {
            var contacts = new List<Contact>
            {
                new Contact { FirstMidName = "Tamara",   LastName = "Iakiri", EmailAddress="test@ostusa.com", PhoneNumber="123-456-7890", StreetAddress="123 Test Street", City="Testville", State=new USState{ StateName = "Alabama", StateAbbreviation = "AL" } },
                new Contact { FirstMidName = "Jeremy", LastName = "Wise", EmailAddress="test@ostusa.com", PhoneNumber="123-456-7890", StreetAddress="123 Test Street", City="Testville", State=new USState{ StateName="Alaska", StateAbbreviation="AK" } },
                new Contact { FirstMidName = "Justin",   LastName = "Keithley", EmailAddress="test@ostusa.com", PhoneNumber="123-456-7890", StreetAddress="123 Test Street", City="Testville", State=new USState{ StateName="Arizona", StateAbbreviation="AZ" } },
                new Contact { FirstMidName = "Matt",    LastName = "Brickner", EmailAddress="test@ostusa.com", PhoneNumber="123-456-7890", StreetAddress="123 Test Street", City="Testville", State=new USState{ StateName = "Arkansas", StateAbbreviation = "AR" } }
            };
            contacts.ForEach(s => context.Contacts.Add(s));
            context.SaveChanges();
        }
    }
}
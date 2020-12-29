using InMemoryContactData.Models;
using System;
using System.Collections.Generic;

namespace InMemoryContactData.Services
{
    public class InMemoryContactsData : IContactData
    {

        List<Contact> contacts;

        public InMemoryContactsData()
        {
            contacts = new List<Contact>()
            {
                new Contact {Name = "Jane Doe", Email = "JaneDoe@alabamaepi.org", Phone = 545-123-3454, Notes = "", Jurisdicton = "Alabama", Role = "" },
                new Contact {Name = "John Doe", Email = "JohnDoe@texasepi.org", Phone = 714-123-3454, Notes = "", Jurisdicton = "Texas", Role = "" },
            };
        }

        public IEnumerable<Contact> GetAll()
        {

            return contacts;
        }
    }
}

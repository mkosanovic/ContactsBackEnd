using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contacts.Domain
{
    public class Contact
    {
        public string Name { get; set; }

        public EMail EMail { get; set; }

        public Telephone Telephone { get; set; }

        public City City {get; set;}
    }
}

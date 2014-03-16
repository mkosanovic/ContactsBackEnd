using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contacts.Domain
{
    public class Telephone
    {
        public string PhoneNumber { get; set; }
         
        public PhoneType Type { get; set; }
    }
}

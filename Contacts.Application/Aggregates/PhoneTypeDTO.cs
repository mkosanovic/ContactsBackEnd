using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contacts.Domain;

namespace Contacts.Application.Aggregates
{
    public class PhoneTypeDTO :BaseEntity<int>
    {
        public string Name { get; set; }
    }
}

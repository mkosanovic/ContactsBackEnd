using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contacts.Domain;
using System.Runtime.Serialization;

namespace Contacts.Application.ValueObjects
{
    [DataContract]
    public class CountryDTO : BaseEntity<int>
    {
        [DataMember]
        public string Name { get; set; }
    }
}

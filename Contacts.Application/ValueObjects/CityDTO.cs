using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Contacts.Domain;

namespace Contacts.Application.ValueObjects
{
    [DataContract]
    public class CityDTO : BaseEntity<int>
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public CountryDTO Country { get; set; }
    }
}

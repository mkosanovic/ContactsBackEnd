using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Contacts.Application.ValueObjects;
using Contacts.Domain;

namespace Contacts.Application.Aggregates
{
    [DataContract]
    public class ContactDTO :BaseEntity<int>
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public EMailDTO EMail { get; set; }

        [DataMember]
        public CityDTO City { get; set; }

        [DataMember]
        public TelephoneDTO Telephone { get; set; }
    }
}

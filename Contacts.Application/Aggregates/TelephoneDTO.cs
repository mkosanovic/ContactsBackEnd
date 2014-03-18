using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Contacts.Domain;

namespace Contacts.Application.Aggregates
{
    [DataContract]
    public class TelephoneDTO : BaseEntity<int>
    {
        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public PhoneTypeDTO PhoneType { get; set; }
    }
}

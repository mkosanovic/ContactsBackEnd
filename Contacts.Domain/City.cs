using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contacts.Domain
{
    [DataContract]
    public class City : BaseEntity<int>
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        [DataMember]
        public int CountryId { get; set; }
    }
}

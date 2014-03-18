using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contacts.Domain
{
    [DataContract]
    public class Telephone : BaseEntity<int>
    {
        [DataMember]
        public string PhoneNumber { get; set; }
         
        [DataMember]
        public int PhoneTypeId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contacts.Domain
{    
    [DataContract]
    public class Contact : BaseEntity<int>
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int EMailId { get; set; }

        [DataMember]
        public int TelephoneId { get; set; }

        [DataMember]
        public int CityId {get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contacts.Domain
{
    [DataContract]
    public class EMail : BaseEntity<int>
    {
        [DataMember]
        public string Address { get; set; }
    }
}

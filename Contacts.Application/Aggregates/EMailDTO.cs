using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contacts.Domain;
using System.Runtime.Serialization;

namespace Contacts.Application.Aggregates
{
    [DataContract]
    public class EMailDTO : BaseEntity<int>
    {
        [DataMember]
        public string Address { get; set; }
    }
}

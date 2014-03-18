using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contacts.Domain
{
    [DataContract]
    public class BaseEntity<T>
    {
        [DataMember]
        public T Id { get; set; }
    }
}

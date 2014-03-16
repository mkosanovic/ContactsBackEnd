using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Contacts.DistributedContext
{
    public class ContactService : IContactService
    {
        public void AddContact()
        {
            throw new NotImplementedException();
        }

        public void EditContact()
        {
            throw new NotImplementedException();
        }

        public void DeleteContact()
        {
            throw new NotImplementedException();
        }
    }

    [ServiceContract]
    public interface IContactService
    {
        [OperationContract]
        void AddContact();

        [OperationContract]
        void EditContact();

        [OperationContract]
        void DeleteContact();
    }
}

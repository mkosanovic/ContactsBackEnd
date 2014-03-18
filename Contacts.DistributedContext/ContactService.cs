using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Contacts.Infrastructure.Persistance;
using Contacts.Domain;
using Contacts.Application.Aggregates;
using Contacts.Application.Services;

namespace Contacts.DistributedContext
{
    /// <summary>
    /// Service for managing contacts.
    /// No dto's are used instead all data is eagerly loaded into domain classes
    /// </summary>
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single, 
                     IncludeExceptionDetailInFaults=true)]
    public class ContactService : IContactService
    {
        private IContactRepository contactRepository;

        public ContactService(IContactRepository contactRepository)
        {            
            this.contactRepository = contactRepository;
        }

        public ContactDTO AddContact(ContactDTO contact)
        {
            return contactRepository.Save(contact);
        }

        public ContactDTO EditContact(ContactDTO contact)
        {
            return contactRepository.Save(contact);
        }

        public int DeleteContact(ContactDTO contact)
        {
            return contactRepository.Delete(contact);
        }
    }

    [ServiceContract]
    public interface IContactService
    {
        [OperationContract]
        ContactDTO AddContact(ContactDTO contact);

        [OperationContract]
        ContactDTO EditContact(ContactDTO contact);

        [OperationContract]
        int DeleteContact(ContactDTO contact);
    }
}

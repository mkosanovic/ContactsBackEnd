using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contacts.Infrastructure.Persistance;
using Contacts.Domain;
using Contacts.Application.Aggregates;
using AutoMapper;
using Contacts.Application.ValueObjects;

namespace Contacts.Application.Services
{
    public class ContactRepository : IContactRepository
    {
        // aggregate root
        private IRepository<Contact> contactRepository;

        // aggregates
        private IRepository<EMail> eMailRepository;
        private IRepository<Telephone> telephoneRepository;

        // value objects
        private IRepository<City> cityRepository;
        private IRepository<Country> countryRepository;

        public ContactRepository(
            IRepository<Contact> contactRepository, 
            IRepository<EMail> emailRepository, 
            IRepository<Telephone> telephoneRepository,
            IRepository<City> cityRepositry,
            IRepository<Country> countryRepository)
        {
            this.contactRepository = contactRepository;

            this.eMailRepository = emailRepository;
            this.telephoneRepository = telephoneRepository;

            this.cityRepository = cityRepository;
            this.countryRepository = countryRepository;
        }

        public ContactDTO Save(ContactDTO contactDTO)
        {
            // transform emailDTO to to email
            var email = Mapper.Map<EMailDTO, EMail>(contactDTO.EMail);            

            // save email if it was updated
            contactDTO.EMail.Id = eMailRepository.Save(email).Id;

            // transform telephoneDTO to telephone
            var telephone = Mapper.Map<TelephoneDTO, Telephone>(contactDTO.Telephone);

            // save telephone
            contactDTO.Telephone.Id = telephoneRepository.Save(telephone).Id;

            var contact = Mapper.Map<ContactDTO, Contact>(contactDTO);

            contactDTO.Id = contactRepository.Save(contact).Id;

            return contactDTO;
        }

        public ContactDTO Get(int contactId)
        {
            var contact = contactRepository.Get(contactId);

            return MapContact(contact);
        }

        public IList<ContactDTO> GetAll()
        {
            return contactRepository.GetAll().Select(MapContact).ToList();
        }

        public int Delete(ContactDTO contactDTO)
        {
            return contactRepository.Delete(Mapper.Map<ContactDTO, Contact>(contactDTO));
        }

        private ContactDTO MapContact(Contact contact)
        {
            // map contact
            var contactDTO = Mapper.Map<Contact, ContactDTO>(contact);

            contactDTO.City = Mapper.Map<City, CityDTO>(cityRepository.Get(contact.CityId));

            contactDTO.City.Country = Mapper.Map<Country, CountryDTO>(
                                        countryRepository.Get(countryRepository.Get(contactDTO.City.Country.Id)));

            contactDTO.Telephone = Mapper.Map<Telephone, TelephoneDTO>(telephoneRepository.Get(contactDTO.Telephone.Id));

            contactDTO.EMail = Mapper.Map<EMail, EMailDTO>(eMailRepository.Get(contactDTO.EMail.Id));

            return contactDTO;
        }
    }

    public interface IContactRepository
    {
        ContactDTO Save(ContactDTO contactDTO);

        ContactDTO Get(int contactId);

        IList<ContactDTO> GetAll();

        int Delete(ContactDTO contactDTO);
    }
}

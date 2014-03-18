using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contacts.Domain;
using NPoco.FluentMappings;

namespace Contacts.Infrastructure.Persistance
{    
    public class CityMapping : Map<City>
    {
        public CityMapping()
        {
            PrimaryKey(x => x.Id);

            TableName("City");

            Columns(x =>
            {
                x.Column(c => c.Name);
                x.Column(c => c.PostalCode);
                x.Column(c => c.CountryId).WithName("CountryID");
            });
        }
    }

    public class CountryMapping : Map<Country>
    {
        public CountryMapping()
        {
            PrimaryKey(x => x.Id);

            TableName("Country");

            Columns(x =>
            {
                x.Column(c => c.Name);
            });
        }
    }

    public class ContactMapping : Map<Contact>
    {
        public ContactMapping()
        {
            PrimaryKey(x => x.Id);

            TableName("Contact");

            Columns(x =>
                {
                    x.Column(c => c.Name);
                    x.Column(c => c.CityId).WithName("CityID");
                    x.Column(c => c.TelephoneId).WithName("TelephoneID");
                    x.Column(c => c.EMailId).WithName("MailID");
                });
        }
    }

    public class TelephoneMapping : Map<Telephone>
    {
        public TelephoneMapping()
        {
            PrimaryKey(x => x.Id);

            TableName("Telephone");

            Columns(x =>
                {
                    x.Column(c => c.PhoneNumber);
                    x.Column(c => c.PhoneTypeId).WithName("PhoneTypeID");
                });
        }
    }

    public class EMailMapping : Map<EMail>
    {
        public EMailMapping()
        {
            PrimaryKey(x => x.Id);

            TableName("EMail");

            Columns(x =>
                {
                    x.Column(c => c.Address);
                });
        }
    }

    public class PhoneTypeMapping : Map<PhoneType>
    {
        public PhoneTypeMapping()
        {
            PrimaryKey(x => x.Id);

            TableName("PhoneType");

            Columns(x =>
            {
                x.Column(c => c.Name);
            });
        }
    }
}

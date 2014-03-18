using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Contacts.Domain;
using Contacts.Application.Aggregates;
using Contacts.Application.ValueObjects;

namespace Contacts.Application.Profiles
{
    public class Profiles : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ContactDTO, Contact>()
                .ForMember(x => x.CityId, map => map.MapFrom(m => m.City.Id))
                .ForMember(x => x.EMailId, map => map.MapFrom(m => m.EMail.Id))
                .ForMember(x => x.TelephoneId, map => map.MapFrom(m => m.Telephone.Id));

            Mapper.CreateMap<EMailDTO, EMail>();

            Mapper.CreateMap<TelephoneDTO, Telephone>()
                .ForMember(x => x.PhoneTypeId, map => map.MapFrom(m => m.PhoneType.Id));


            // reverse mapping
            Mapper.CreateMap<Contact, ContactDTO>();

            Mapper.CreateMap<City, CityDTO>();

            Mapper.CreateMap<Country, CountryDTO>();

            Mapper.CreateMap<Telephone, TelephoneDTO>();

            Mapper.CreateMap<EMail, EMailDTO>();

        }
    }
}

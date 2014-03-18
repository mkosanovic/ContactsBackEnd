using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Contact.DistributedContext.Test.ContactServiceReference;

namespace Contact.DistributedContext.Test
{
    [TestFixture]
    public class Tests
    {
        public void Insert_Should_InsertRecord()
        {
            // arrange
            // create endpoint
            //dynamic contact = new object();
            //contact.Name = "First contact";
            //contact.EMail = "First email";

            using (var factory = CreateFactory())
            {
                var channel = factory.CreateChannel();
                try
                {
                    channel.Open();

                    //Message request = Message.CreateMessage(MessageVersion.Soap11, "fail");

                    //using (var reply = channel.Request(request))
                    //{
                    //    var blah = reply.Headers.Action;
                    //}

                    channel.AddContact(new ContactServiceReference.ContactDTO
                    {
                        City = new ContactServiceReference.CityDTO
                        {
                            Id = 1,
                            Country = new ContactServiceReference.CountryDTO { Id = 1 }
                        },
                        Name = "First contact",
                        EMail = new ContactServiceReference.EMailDTO
                        {
                            Address = "firstContact@mail.com"
                        },
                        Telephone = new ContactServiceReference.TelephoneDTO
                        {
                            PhoneNumber = "123",
                            PhoneType = new ContactServiceReference.PhoneTypeDTO { Id = 1 }
                        }
                    });
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    channel.Close();
                }


            }
        }

        private ChannelFactory<IContactServiceChannel> CreateFactory()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress address = new EndpointAddress("http://localhost:4444/Services");

            var factory = new ChannelFactory<IContactServiceChannel>(binding, address);

            return factory;
        }
    }
}

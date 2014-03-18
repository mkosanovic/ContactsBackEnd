using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Contacts.Infrastructure.Persistance;
using AutoMapper;
using Contacts.Application.Profiles;
using Contacts.Application.Services;

namespace Contacts.DistributedContext.Host
{
    public class Bootstrapper
    {
        public static WindsorContainer Bootstrap()
        {
            var container = new WindsorContainer();

            container.Register(
                Component.For(typeof(IRepository<>)).ImplementedBy(typeof(NRepository<>)),
                // ensure db factory is initiated
                Component.For<IDatabaseFactory>().ImplementedBy<DBFactory>().OnCreate((kernel, instance) => instance.Setup()).LifeStyle.Singleton,
                Component.For<IContactService>().ImplementedBy<ContactService>(),
                Component.For<IContactRepository>().ImplementedBy<ContactRepository>()
            );

            // init bootstrapper
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<Profiles>();
            });

            return container;
        }
    }
}

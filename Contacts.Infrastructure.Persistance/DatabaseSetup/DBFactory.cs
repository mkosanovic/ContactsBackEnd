using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPoco;
using NPoco.FluentMappings;
using System.Configuration;
using Castle.Core;

namespace Contacts.Infrastructure.Persistance
{
    public interface IDatabaseFactory
    {
        Database GetDatabase();

        void Setup();
    }

    public class DBFactory : IDatabaseFactory
    {
        public DatabaseFactory DbFactory { get; set; }

        public void Setup()
        {
            // get all mappings from class
            var mappingTypes = typeof(DBFactory).Assembly
                                                .GetTypes()
                                                .Where(x => x.GetInterface(typeof(IMap).FullName) != null);
            // instantiate all types
            var mappingInstances = mappingTypes.Select(x => Activator.CreateInstance(x) as IMap).ToArray();

            // fluent configuration
            var fluentConfig = FluentMappingConfiguration.Configure(mappingInstances);

            // init database factory
            // read connection string from configuration file
            DbFactory = DatabaseFactory.Config(x =>
            {
                x.UsingDatabase(() => new DatabaseWithLoging(ConfigurationManager.ConnectionStrings[0].Name));
                x.WithFluentConfig(fluentConfig);
            });
        }

        public Database GetDatabase()
        {
            return DbFactory.GetDatabase();
        }

        public void Initialize()
        {
            Setup();
        }
    }
}

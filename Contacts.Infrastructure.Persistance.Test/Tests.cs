using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Reflection;
using NPoco.FluentMappings;
using Shouldly;

namespace Contacts.Infrastructure.Persistance.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void MappingsCount_ShouldBe_5()
        {
            // arrange
            var mappings = typeof(DBFactory).Assembly
                                                   .GetTypes()
                                                   .Where(x => x.GetInterface(typeof(IMap).FullName) != null);
            
            // act            

            // assert
            mappings.Count().ShouldBe(6);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Contacts.DistributedContext.Host
{
    public class Program
    {
        static void Main(string[] args)
        {
            // this is actually installer :)
            var container = Bootstrapper.Bootstrap();
            
            var contactService = container.Resolve<IContactService>();

            // host wcf service
            using(ServiceHost host = new ServiceHost(contactService))
            {
                host.Open();

                Console.WriteLine("Press any key to stop the service");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}

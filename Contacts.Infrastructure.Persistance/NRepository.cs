
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contacts.Infrastructure.Persistance
{
    public class NRepository<T> : IRepository<T>
    {
        public IList<T> Get<T>()
        {
            throw new NotImplementedException();
        }

        public T Save<T>()
        {
            throw new NotImplementedException();
        }

        public void Delete<T>()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contacts.Infrastructure.Persistance
{
    public interface IRepository<T>
    {
        IList<T> Get<T>();

        T Save<T>();

        void Delete<T>();
    }
}

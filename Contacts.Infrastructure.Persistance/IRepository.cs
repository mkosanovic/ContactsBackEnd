using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contacts.Domain;

namespace Contacts.Infrastructure.Persistance
{
    public interface IRepository<T> where T : BaseEntity<int>
    {
        IList<T> GetAll();

        T Get(T entity);

        T Get(object id);

        T Save(T entity);

        int Delete(T entity);
    }
}

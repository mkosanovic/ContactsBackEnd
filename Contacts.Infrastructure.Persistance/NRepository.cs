
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contacts.Domain;

namespace Contacts.Infrastructure.Persistance
{
    public class NRepository<T> : IRepository<T> where T : BaseEntity<int>
    {
        public IDatabaseFactory DatabaseFactory { get; set; }

        public NRepository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        public IList<T> GetAll()
        {
            return DatabaseFactory.GetDatabase().Fetch<T>();
        }

        public T Get(T entity)
        {
            return Get(entity.Id);
        }

        public T Get(object id)
        {
            return DatabaseFactory.GetDatabase().SingleById<T>(id);
        }

        public T Save(T entity)
        {
            var context = DatabaseFactory.GetDatabase();

            var id = context.Exists<T>(entity.Id)
                                ? context.Update(entity)
                                : context.Insert<T>(entity);

            return context.SingleById<T>(id);
        }

        public int Delete(T entity)
        {
            return DatabaseFactory.GetDatabase().Delete<T>(entity);
        }        
    }
}

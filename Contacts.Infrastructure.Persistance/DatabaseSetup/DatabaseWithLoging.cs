using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPoco;

namespace Contacts.Infrastructure.Persistance
{
    public class DatabaseWithLoging : Database
    {
        public DatabaseWithLoging(string connectionStringName) : base(connectionStringName) { }

        protected override void OnExecutingCommand(System.Data.IDbCommand cmd)
        {
            // log sql
            
            base.OnExecutingCommand(cmd);
        }
    }
}

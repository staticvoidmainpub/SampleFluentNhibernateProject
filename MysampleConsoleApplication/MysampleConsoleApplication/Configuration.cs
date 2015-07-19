using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using MysampleConsoleApplication.Model;

namespace MysampleConsoleApplication
{
    public class Configuration
    {
        public static ISessionFactory CreateSessionFactory()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(@"Data Source=.;Initial Catalog=sampledb;Integrated Security=True"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Catagory>())
                .BuildSessionFactory();
            return sessionFactory;
                
        }
    }
}

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using IoCExample.Domain;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace IoCExample
{
    public static class NHibernateProvider
    {
        private static ISessionFactory _sessionFactory;

        public static ISession GetSession()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = BuildSessionFactory();
            }

            return _sessionFactory.OpenSession();
        }

        private static ISessionFactory BuildSessionFactory()
        {
            var assembly = typeof(Employee).Assembly;

            var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(x => x.Database("NHibernateDemo").Server("RODSK40050").TrustedConnection()))
                .Mappings(x => x.FluentMappings.AddFromAssembly(assembly))
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true));

            return configuration.BuildSessionFactory();
        }

    }
}

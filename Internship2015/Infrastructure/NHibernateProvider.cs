using System;
using System.Runtime.Serialization;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using University.Domain.Mappings;

namespace University.Infrastructure
{
    public static class NHibernateProvider
    {
        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var mappingsAssembly = typeof (CollageMap).Assembly;

                var configuration = Fluently.Configure()
                    .Database(
                        MsSqlConfiguration.MsSql2012.ConnectionString(
                            x => x.Database("UniversityDemo").Server("RODSK40050").TrustedConnection()))
                    .Mappings(x => x.FluentMappings.AddFromAssembly(mappingsAssembly))
                    .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true));

                return configuration.BuildSessionFactory();
            }
            catch (Exception e)
            {
                var ex = GetMostInnerException(e);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return null;
           
        }

        public static ISessionFactory SessionFactory;

        public static ISession GetSession()
        {
            if (SessionFactory == null)
            {
                SessionFactory = CreateSessionFactory();
            }
            return SessionFactory.OpenSession();
        }

        public static Exception GetMostInnerException(Exception ex)
        {
            var inner = ex;
            while (inner.InnerException != null)
            {
                inner = inner.InnerException;
                Console.WriteLine(inner.Message);
                Console.WriteLine();
            }

            return inner;
        }


    }

}

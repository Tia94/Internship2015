using NHibernate;
using University.Domain;

namespace University.Repository
{
    public class Repository<T> where T : Entity
    {
        protected readonly ISession Session;

        public Repository(ISession session)
        {
            Session = session;
        }

        public void Save(T entity)
        {
            Session.Save(entity);
        }
    }
}
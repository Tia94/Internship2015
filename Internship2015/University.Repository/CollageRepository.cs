using System.Collections.Generic;
using NHibernate;
using University.Domain;
using University.Repository.Interface;

namespace University.Repository
{
    public class CollageRepository : Repository<Collage>, ICollageRepository
    {
        public CollageRepository(ISession session)
            : base(session)
        {

        }

        public IList<Collage> GetAll()
        {
            return Session.QueryOver<Collage>().List();
        }

    }
}

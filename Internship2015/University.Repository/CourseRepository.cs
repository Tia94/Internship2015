using System.Collections.Generic;
using NHibernate;
using University.Domain;
using University.Repository.Interface;

namespace University.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {


        public CourseRepository(ISession session)
            : base(session)
        {
        }

        public IList<Course> GetAll()
        {
            return Session.QueryOver<Course>().List();
        }

        public IList<Course> GetByName(string name)
        {
            return Session.QueryOver<Course>().Where(c => c.Name == name).List();
        }
    }
}
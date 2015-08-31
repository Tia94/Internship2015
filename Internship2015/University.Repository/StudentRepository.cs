using System.Collections.Generic;
using NHibernate;
using University.Domain;
using University.Repository.Interface;

namespace University.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ISession session)
            : base(session)
        {
        }

        public IList<Student> GetAll()
        {
            return Session.QueryOver<Student>().List();
        }

        public IList<Student> GetByFirstname(string firstname)
        {
            return Session.QueryOver<Student>().Where(c => c.Firstname == firstname).List();
        }

        public string GetStudentNameById(int studentId)
        {
            return Session.QueryOver<Professor>()
               .Where(c => c.Id == studentId)
               .Select(c => c.Firstname)
               .SingleOrDefault<string>();
        }
    }
}

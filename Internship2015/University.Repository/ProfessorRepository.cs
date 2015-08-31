using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using University.Domain;
using University.Repository.Interface;

namespace University.Repository
{
    public class ProfessorRepository :Repository<Professor>, IProfessorRepository
    {
      

        public ProfessorRepository(ISession session):base(session)
        {
        }

       public IList<Professor> GetAll()
        {
            return Session.QueryOver<Professor>().List();
        }

        public IList<Professor> GetByFirstname(string firstname)
        {
            return Session.QueryOver<Professor>().Where(c => c.Firstname == firstname).List();
        }


        public string GetProfessorNameById(int professorId)
        {
            return Session.QueryOver<Professor>()
                .Where(c => c.Id == professorId)
                .Select(c => c.Firstname)
                .SingleOrDefault<string>();
        }
    }
}

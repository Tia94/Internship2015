using System.Collections.Generic;
using University.Domain;

namespace University.Repository.Interface
{
    public interface IProfessorRepository
    {

        IList<Professor> GetAll();
        IList<Professor> GetByFirstname(string firstname);
       string GetProfessorNameById(int professorId);
    }
}

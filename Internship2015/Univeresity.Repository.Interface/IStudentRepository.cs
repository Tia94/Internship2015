using System.Collections.Generic;
using University.Domain;

namespace University.Repository.Interface
{
   public interface IStudentRepository
    {
        IList<Student> GetAll();
        IList<Student> GetByFirstname(string firstname);
        string GetStudentNameById(int studentId);
       void Save(Student student);
    }
}

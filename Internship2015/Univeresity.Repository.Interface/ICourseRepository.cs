using System.Collections.Generic;
using University.Domain;

namespace University.Repository.Interface
{
     public interface ICourseRepository
    {
         IList<Course> GetAll();
        IList<Course> GetByName(string name);
    }
}

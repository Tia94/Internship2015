using System.Collections.Generic;
using University.Domain;

namespace University.Repository.Interface
{
    public interface ICollageRepository
    {
        IList<Collage> GetAll();
    }
}

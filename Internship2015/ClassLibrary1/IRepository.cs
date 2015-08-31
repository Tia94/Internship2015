using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoCExample.Domain;


namespace ClassLibrary1
{
    public interface IRepository
    {
        void Save<TEntity>(TEntity entity) where TEntity : Entity;
    }
}

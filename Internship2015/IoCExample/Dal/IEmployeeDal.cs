
using System.Collections.Generic;
using IoCExample.Domain;


namespace IoCExample.Dal
{
    public interface IEmployeeDal
    {
        IList<Employee> GetAllEmployees();
    }
}

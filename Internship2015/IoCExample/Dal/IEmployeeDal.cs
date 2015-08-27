
using System.Collections.Generic;


namespace IoCExample.Dal
{
    public interface IEmployeeDal
    {
        IList<Employee> GetAllEmployees();
    }
}

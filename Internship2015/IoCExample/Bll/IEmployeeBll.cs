using System.Collections.Generic;
using IoCExample.Domain;


namespace IoCExample.Bll
{
    public interface IEmployeeBll
    {
        IList<Employee> GetEmployees();
    }
}

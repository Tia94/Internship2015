using System.Collections.Generic;


namespace IoCExample.Bll
{
    public interface IEmployeeBll
    {
        IList<Employee> GetEmployees();
    }
}

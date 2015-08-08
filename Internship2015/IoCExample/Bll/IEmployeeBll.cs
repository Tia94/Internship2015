using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCExample.Bll
{
    interface IEmployeeBll
    {
        IList<Employee> GetEmployees();
    }
}

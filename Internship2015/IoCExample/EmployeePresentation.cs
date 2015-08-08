using IoCExample.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCExample
{
    class EmployeePresentation
    {
        private IEmployeeBll _bll;
 
        public EmployeePresentation(IEmployeeBll bll)
        {
            _bll = bll;
        }

        public void ShowEmployeesOnConsole()
        {
            var list = _bll.GetEmployees();

            foreach(var item in list)
            {
                Console.WriteLine("Name: {0}, Salary: {1}, Address: {2}", item.Name, item.Salary, item.Address);
            }
        }
    }
}

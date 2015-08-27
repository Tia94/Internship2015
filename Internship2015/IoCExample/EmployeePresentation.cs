using IoCExample.Bll;
using System;


namespace IoCExample
{
    public class EmployeePresentation
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

using IoCExample.Bll;
using IoCExample.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace IoCExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFilePath path = new FilePath(@"D:\Employees.xml");
            //IEmployeeDal dal = new EmployeeDal(path);
            //IEmployeeBll bll = new EmployeeBll(dal);
            //var presentation = new EmployeePresentation(bll);
            //presentation.ShowEmployeesOnConsole();

            var container = new UnityContainer();
            

            Console.ReadLine();
        }
    }
}

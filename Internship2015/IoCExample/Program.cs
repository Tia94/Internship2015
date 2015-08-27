using System;
using IoCExample.Bll;
using IoCExample.Dal;
using Microsoft.Practices.Unity;

namespace IoCExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myContainer = new UnityContainer();

            var filePath = new FilePath(@"C:\Test\Employees.xml");
            myContainer.RegisterInstance<IFilePath>(filePath);

            myContainer.RegisterType<IEmployeeDal, EmployeeDal>();
            myContainer.RegisterType<IEmployeeBll, EmployeeBll>();
            myContainer.RegisterType<EmployeePresentation>();

            var employeePresentation = myContainer.Resolve<EmployeePresentation>();
            employeePresentation.ShowEmployeesOnConsole();


            Console.ReadLine();
        }
    }
}

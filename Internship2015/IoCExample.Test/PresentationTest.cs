using System.Collections.Generic;
using IoCExample.Bll;
using IoCExample.Domain;
using Moq;
using NUnit.Framework;

namespace IoCExample.Test
{
    [TestFixture]
    public class PresentationTest
    {
        private EmployeePresentation _employeePresentation;
        private Mock<IEmployeeBll> _employeeBll;
        
        [SetUp]
        public void Setup()
        {
            _employeeBll = new Mock<IEmployeeBll>();
            _employeePresentation = new EmployeePresentation(_employeeBll.Object);
        }

        [TestCase]
        public void ShowEmployeesOnConsoleTest()
        {
            //Arrange
            var list = new List<Employee>
            {
                new Employee()
            };
            _employeeBll.Setup(x => x.GetEmployees()).Returns(list);

            //Act
             _employeePresentation.ShowEmployeesOnConsole();

            //Assert
             _employeeBll.Verify(x => x.GetEmployees(), Times.Once);

             
        }
    }
}

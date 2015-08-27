using System.Collections.Generic;
using IoCExample.Bll;
using IoCExample.Dal;
using Moq;
using NUnit.Framework;

namespace IoCExample.Test
{
    [TestFixture]
    public class EmployeeBllTest
    {
        private EmployeeBll _employeeBll;
        private Mock<IEmployeeDal> _employeeDal;

        [SetUp]
        public void Setup()
        {
            _employeeDal =new Mock<IEmployeeDal>();
            _employeeBll = new EmployeeBll(_employeeDal.Object);
        }

        [TestCase]
        public void GetEmployeesTest()
        {
            // Arrange
            var list = new List<Employee>
            {
                new Employee()
            };

            _employeeDal.Setup(x => x.GetAllEmployees()).Returns(list);

            // Act
            var employees = _employeeBll.GetEmployees();

            // Assert
            _employeeDal.Verify(x => x.GetAllEmployees(), Times.Once);

            Assert.AreEqual(list, employees);
        }
    }
}

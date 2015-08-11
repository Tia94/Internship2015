using IoCExample.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCExample.Bll
{
    class EmployeeBll : IEmployeeBll
    {
        private IEmployeeDal _dal;

        public EmployeeBll(IEmployeeDal dal)
        {
            _dal = dal;
        }

        public IList<Employee> GetEmployees()
        {
            var list =  _dal.GetAllEmployees();
            return list;
        }
    }
}

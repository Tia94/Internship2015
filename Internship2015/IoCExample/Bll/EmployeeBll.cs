using IoCExample.Dal;

using System.Collections.Generic;


namespace IoCExample.Bll
{
    public class EmployeeBll : IEmployeeBll
    {
        private IEmployeeDal _dal;

        public EmployeeBll(IEmployeeDal dal)
        {
            _dal = dal;
        }

        public IList<Employee> GetEmployees()
        {
            var list =  _dal.GetAllEmployees();
            //
            return list;
        }
    }
}


using System;
using System.Collections;

namespace IoCExample.Domain
{
    public class Employee :Entity
    {
        public virtual string Name { get; set; }
        public  virtual decimal Salary { get; set; }
        public  virtual string Address { get; set; }

        //public Employee(string name, decimal salary, string address)
        //{
        //    if (string.IsNullOrWhiteSpace(name))
        //        throw new ArgumentException("name is required.");
        //    if (salary <= 0)

        //        throw new ArgumentException("price must be positive.");
       
        //    Name = name;
        //    Salary = salary;
        //    Address = address;
            
        //}
        [Obsolete]
        public Employee()
        {
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
  public static class SalaryExtension
    {
        public static decimal SalarySum(this List <Worker> workers)
      {
          decimal sum = 0;
            foreach(var w in workers )
            {
               sum =sum + w.Salary;
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    static class Company
    {
       public static List<Worker> GetWorkers()
       { 
           var workers = new List<Worker>();

           var worker1 = new Worker()
           {
               Name = "Patricia Atieyeh",
               Salary = 1000,
               StartedYear = 2015,
               State = State.Working
           };

           var worker2 = new Worker()
           {
               Name = "Rami Atieyeh",
               Salary = 3000,
               StartedYear = 2013,
               State = State.Resting
           };

           var worker3 = new Worker()
           {
               Name = "Shaza Atieyeh",
               Salary = 2000,
               StartedYear = 2014,
               State = State.Home
           };

           workers.Add(worker1);
           workers.Add(worker2);
           workers.Add(worker3);

           return workers;
       }
    }
}

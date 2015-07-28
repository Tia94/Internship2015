using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    sealed class Company
    {
        private static readonly object obj = new object();

        private static Company instance;

        public static Company Instance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Company();
                    }

                    return instance;
                }

            }
        }

        private Company()
        {

        }

        public List<Worker> GetWorkers()
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

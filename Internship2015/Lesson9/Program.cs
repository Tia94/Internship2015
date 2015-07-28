using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The options are:");
            Console.WriteLine("1. All workers");
            Console.WriteLine("2. All the working");
            Console.WriteLine("3. All at home");
            Console.WriteLine("4. All Resting");
            Console.WriteLine("5. The sum of Salaries");
            Console.WriteLine("6. Employees with salary greater than 2000");

            var company = Company.Instance;

            string option;

            do
            {
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        {
                            ShowWorkers();
                            break;
                        }
                    case "2":
                        {
                            Show(IsWorking);
                            break;
                        }
                    case "3":
                        {
                            Show(delegate(Worker w)
                            {
                                return w.State == State.Home;
                            });
                            break;
                        }
                    case "4":
                        {
                            Show(w => w.State == State.Resting);
                            break;
                        }
                    case "5":
                        {
                            //var sum= SalaryExtension.SalarySum(Factory.GetWorkers());
                            //Console.WriteLine(sum);
                            var sum = company.GetWorkers().SalarySum();
                            Console.WriteLine(sum);
                            break;
                        }
                    case "6":
                        {
                            var workerSalary = from w in company.GetWorkers()
                                               where w.Salary >= 2000
                                               select w.Name + " " + w.StartedYear;
                            foreach (var w in workerSalary)
                            {
                                Console.WriteLine(w);
                            }
                            break;
                        }
                }
            }
            while (option != "exit");

        }

        public delegate bool WantedState(Worker w);

        public static bool IsWorking(Worker w)
        {
            return w.State == State.Working;
        }

        public static void ShowWorkers()
        {
            var company = Company.Instance;
            var workers = company.GetWorkers();

            foreach (Worker w in workers)
            {
                Console.WriteLine(w.GetDetails());
            }
        }

        public static void Show(WantedState state)
        {
            var company = Company.Instance;
            var workers = company.GetWorkers();

            foreach (Worker w in workers)
            {
                if (state(w))
                    Console.WriteLine(w.GetDetails());
            }
        }
    }
}

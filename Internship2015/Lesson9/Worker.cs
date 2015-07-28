using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    public enum State { Working, Resting, Home }

    public class Worker
    {
        public string Name{get; set;}
        public decimal Salary { get; set; }
        public State State { get; set; }
        public int StartedYear { get; set; }

        public string GetDetails()
        {
            return (Name + ", " + State);
        }
    }
}

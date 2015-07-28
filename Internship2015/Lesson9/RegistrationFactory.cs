using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    static class RegistrationFactory
    {
        public static Registration Create(string learnerName, string courseTitle, string centreAddress)
        {
            var l = new Learner(learnerName);

            var c = new Course
            {
                Title = courseTitle
            };

            var centre = new Centre
            {
                    Address = centreAddress
            };

            var dt = DateTime.Now;

            var reg = new Registration(l, c, centre, dt);

            return reg;
        }
    }
}

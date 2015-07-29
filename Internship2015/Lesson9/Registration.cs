using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Learner
    {
        public string Name { get; set; }

        public Learner(string name)
        {
            Name = name;
        }
    }

    class Course
    {
        public string Title { get; set; }
    }

    class Centre
    {
        public string Address { get; set; }
    }

    class Registration
    {
        public DateTime Date { get; set; }
        public Learner Learner { get; set; }
        public Course Course { get; set; }
        public Centre Centre { get; set; }

        public Registration(Learner learner, Course course, Centre centre, DateTime dt)
        {

        }
    }
}

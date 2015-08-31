using System.Collections.Generic;

namespace University.Domain
{
    public class Student : Entity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Collage Collage { get; set; }

        public IList<Course> Courses { get; protected set; }

        public Student()
        {
            Courses = new List<Course>();
        }
    }
}
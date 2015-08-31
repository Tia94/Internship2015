using System.Collections.Generic;

namespace University.Domain
{
    public class Professor : Entity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public IList<Course> Courses { get; protected set; }

        public Professor()
        {
            Courses = new List<Course>();
        }
    }
}
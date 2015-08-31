using System.Collections.Generic;

namespace University.Domain
{
    public class Professor : Entity
    {
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual IList<Course> Courses { get; protected set; }
               
        public Professor()
        {
            Courses = new List<Course>();
        }
    }
}
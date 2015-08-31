using System.Collections.Generic;

namespace University.Domain
{
    public class Student : Entity
    {
        public Student()
        {
            Courses = new List<Course>();
        }

        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual Collage Collage { get; set; }

        public virtual IList<Course> Courses { get; protected set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Firstname, Lastname);
        }


    }
}
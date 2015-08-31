using System.Collections.Generic;

namespace University.Domain
{
    public class Collage : Entity
    {
        public  virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual IList<Course> Courses { get; protected set; }
        public virtual IList<Professor> Professors { get; protected set; }

        public Collage()
        {
            Courses = new List<Course>();
            Professors = new List<Professor>();
        }
    }
}

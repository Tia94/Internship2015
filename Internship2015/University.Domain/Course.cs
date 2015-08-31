using System.Collections.Generic;

namespace University.Domain
{
    public class Course : Entity
    {
        public virtual string Name { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual IList<Student> Students { get; protected set; }
             
        public Course()
        {
            Students = new List<Student>();
        }
    }
}

using System.Collections.Generic;

namespace University.Domain
{
    public class Course : Entity
    {
        public string Name { get; set; }
        public Professor Professor { get; set; }
        public IList<Student> Students { get; protected set; }

        public Course()
        {
            Students = new List<Student>();
        }
    }
}

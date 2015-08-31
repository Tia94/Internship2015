using System.Collections.Generic;

namespace University.Domain
{
    public class Collage : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Course> Courses { get; protected set; }
        public IList<Professor> Professors { get; protected set; }

        public Collage()
        {
            Courses = new List<Course>();
            Professors = new List<Professor>();
        }
    }
}

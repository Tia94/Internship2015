using System;
using University.Presentation.Interface;
using University.Repository.Interface;

namespace University.Presentation
{
    public class CoursePresentation : ICoursePresentation
    {
        private readonly ICourseRepository _courserepository;

        public CoursePresentation(ICourseRepository courseRepository)
        {
            _courserepository = courseRepository;
        }

        public void ShowAllCourses()
        {
            var courses = _courserepository.GetAll();
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}

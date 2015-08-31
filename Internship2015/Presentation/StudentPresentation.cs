using System;
using University.Domain;
using University.Presentation.Interface;
using University.Repository.Interface;

namespace University.Presentation
{
    public class StudentPresentation : IStudentPresentation
    {
        private readonly IStudentRepository _studentRepository;

        public StudentPresentation(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void ShowAllStudents()
        {
            var students = _studentRepository.GetAll();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public void Save(Student student)
        {
            _studentRepository.Save(student);
        }
    }
}

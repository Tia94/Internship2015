using University.Domain;

namespace University.Presentation.Interface
{
    public interface IStudentPresentation
    {
        void ShowAllStudents();
        void Save(Student student);
    }
}

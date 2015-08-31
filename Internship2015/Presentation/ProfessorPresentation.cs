using System;
using University.Presentation.Interface;
using University.Repository.Interface;

namespace University.Presentation
{
    public class ProfessorPresentation : IProfessorPresentation
    {
        private readonly IProfessorRepository _professorRepositoy;

        public ProfessorPresentation(IProfessorRepository professorRepository)
        {
            _professorRepositoy = professorRepository;
        }

        public void ShowAllProfessors()
        {
            var professors = _professorRepositoy.GetAll();
            foreach (var professor in professors)
            {
                Console.WriteLine(professor);
            }
        }
    }
}

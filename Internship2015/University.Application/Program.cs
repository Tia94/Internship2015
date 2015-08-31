using System;
using University.Domain;
using University.Infrastructure;
using University.Presentation.Interface;

namespace University.Application
{
    class Program
    {
        static Program()
        {
            IoC.RegisterAll();
        }

        static void Main(string[] args)
        {
            var s = new Student();
            s.Firstname = "Patricia";
            s.Lastname="lkkdklsm";
           
            var studentPresentation = IoC.Resolve<IStudentPresentation>();
            studentPresentation.Save(s);
            studentPresentation.ShowAllStudents();
            Console.ReadLine();
        }
    }
}

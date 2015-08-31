using Microsoft.Practices.Unity;
using University.Presentation;
using University.Presentation.Interface;
using University.Repository;
using University.Repository.Interface;

namespace University.Infrastructure
{
   public static class IoC
   {
       private static readonly UnityContainer Container;

       static IoC()
       {
           if (Container == null)
           {
               Container = new UnityContainer();
           }
       }

       public static void RegisterAll()
       {
           Container.RegisterType<ICollageRepository, CollageRepository>();
           Container.RegisterType<IProfessorRepository, ProfessorRepository>();
           Container.RegisterType<IStudentRepository, StudentRepository>();
           Container.RegisterType<ICourseRepository,CourseRepository>();
          
           Container.RegisterType<ICoursePresentation, CoursePresentation>();
           Container.RegisterType<IStudentPresentation,StudentPresentation>();
           Container.RegisterType<IProfessorPresentation,ProfessorPresentation>();
           Container.RegisterType<ICollagePresentation, CollagePresentation>();


           Container.RegisterInstance(NHibernateProvider.GetSession());
       }

       public static T Resolve<T>()
       {
           return Container.Resolve<T>();
       }
   }
}

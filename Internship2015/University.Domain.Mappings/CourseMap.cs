using FluentNHibernate.Mapping;

namespace University.Domain.Mappings
{
      public  class CourseMap:ClassMap<Course>
        {
          public CourseMap()
          {
              Table("Course");
              Id(x => x.Id).GeneratedBy.Identity();

              Map(x => x.Name).Not.Nullable();

              References(x => x.Professor).Column("ProfessorId");

              HasManyToMany(x => x.Students)
                  .Table("CourseStudent")
                  .ParentKeyColumn("CourseID")
                  .ChildKeyColumn("StudentID");

             
          }


        }
}

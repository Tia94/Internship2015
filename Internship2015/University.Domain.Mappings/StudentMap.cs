using FluentNHibernate.Mapping;

namespace University.Domain.Mappings
{
    class StudentMap:ClassMap<Student>
    {
        public StudentMap()
        {
            Table("Student");
            Id(x => x.Id).GeneratedBy.Identity();

            Map(x => x.Firstname).Not.Nullable();
            Map(x => x.Lastname).Not.Nullable();

            References(x => x.Collage).Column("CollageId");
            
            HasManyToMany(x => x.Courses)
                .Table("CourseStudent")
                .ParentKeyColumn("CourseID")
                .ChildKeyColumn("StudentID");
        }

    }
}


using FluentNHibernate.Mapping;


namespace University.Domain.Mappings
{
    public class CollageMap :ClassMap<Collage>
    {
        public CollageMap()
        {
            Table("Collage");
            Id(x => x.Id).GeneratedBy.Identity();

            Map(x => x.Name).Not.Nullable();
            Map(x => x.Address);

            HasManyToMany(x => x.Courses).Table("CollageCourse").ParentKeyColumn("CollageID").ChildKeyColumn("CourseID");


        }
    }
}

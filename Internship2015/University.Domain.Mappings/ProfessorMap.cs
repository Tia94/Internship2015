using FluentNHibernate.Mapping;

namespace University.Domain.Mappings
{
    class ProfessorMap : ClassMap<Professor>
    {
        public ProfessorMap()
        {
            Table("Professor");
            Id(x => x.Id).GeneratedBy.Identity();

            Map(x => x.Firstname).Not.Nullable();
            Map(x => x.Lastname).Not.Nullable();

            HasMany(x => x.Courses)
                .KeyColumn("ProfessorId")
                .Inverse();
        }
    }
}

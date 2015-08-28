using FluentNHibernate.Mapping;
using IoCExample.Domain;

namespace IoCExample.Mappings
{
    public class EmployeeMap:ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Table("Employee");
            Id(x => x.Id);

            Map(x => x.Name).Not.Nullable();
            Map(x => x.Salary).Not.Nullable();
            Map(x => x.Address);

        }
    }
}
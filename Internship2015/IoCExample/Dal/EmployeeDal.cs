
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Xml.Linq;


namespace IoCExample.Dal
{
    public class EmployeeDal : IEmployeeDal
    {
        private IFilePath _filePath;

        public EmployeeDal(IFilePath filePath)
        {
            _filePath = filePath;
        }

        //XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));

        public IList<Employee> GetAllEmployees()
        {
            var str = File.ReadAllText(_filePath.Path, Encoding.ASCII);
            var doc = XDocument.Parse(str);

            var list = (from r in doc.Root.Elements("Employee")
                       select new Employee
                       {
                           Name = (string)r.Element("Name"),
                           Salary = (decimal)r.Element("Salary"),
                           Address = (string)r.Element("Address")
                       }).ToList();

            return list;
            
        }
    }
}

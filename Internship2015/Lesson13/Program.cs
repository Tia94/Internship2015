using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client
            {
                Name = "Tia"
            };

            var company = new Company
            {
                Name = "eMAG",
                Address = "Timisoara"
            };

            IDeliverProduct showRoomMethod = new ShowRoom();
            IDeliverProduct courierMetohd = new Courier();
            client.BuyProduct("Laptop Lenovo", company, showRoomMethod);

            client.BuyProduct("Laptop Lenovo", company, courierMetohd);

            Console.ReadLine();
        }
    }
}

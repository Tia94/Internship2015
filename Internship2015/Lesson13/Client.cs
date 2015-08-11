using System.Collections.Generic;

namespace Lesson13
{
    public class Client
    {
        public Client()
        {
            Products = new List<Product>();
        }

        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public void BuyProduct(string name, Company company, IDeliverProduct deliveryMetohd)
        {
            var product = company.GetProduct(name, deliveryMetohd);
            Products.Add(product);
        }

    }
}
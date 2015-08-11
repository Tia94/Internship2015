namespace Lesson13
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Product GetProduct(string name, IDeliverProduct deliveryMetohd)
        {
            var product = new Product
            {
                Id = 10,
                Category = "Test",
                Name = name
            };

            deliveryMetohd.DeliverProduct(product);

            return product;
        }
    }
}
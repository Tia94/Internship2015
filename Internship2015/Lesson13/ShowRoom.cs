using System;

namespace Lesson13
{
    public class ShowRoom : IDeliverProduct
    {
        public void DeliverProduct(Product product)
        {
            Console.WriteLine(string.Format("Product {0} was delivered to the clinet at showroom.", product.Name));
        }
    }
}
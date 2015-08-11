using System;

namespace Lesson13
{
    public class Courier : IDeliverProduct
    {
        public void DeliverProduct(Product product)
        {
            Console.WriteLine(string.Format("Product {0} was delivered to client's home by courier.", product.Name));

            
        }
    }
}
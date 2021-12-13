using System;
using System.Threading.Tasks;

namespace GuitarShack.App
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            var alert = new TestReorderAlert();
            await new StockMonitor(alert).OnSale(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
        }
    }

    internal class TestReorderAlert : IReorderAlert
    {
        public void Send(Product product)
        {
            Console.WriteLine($"Please reorder product {product.id} - {product.description}");
        }
    }
}
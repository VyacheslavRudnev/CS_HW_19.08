using ConsoleApp190823.Domain.Interfaces;
using ConsoleApp190823.Domain.Models;


namespace ConsoleApp190823.Domain.UseCases
{
    public class ProductHandler : IOutput<Product>
    {

        public void Print(Product product)
        {
            System.Console.WriteLine(product);
        }
    }
}

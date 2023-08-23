//using Product = ConsoleApp190823.Domain.Models.Product;

namespace ConsoleApp190823.Domain.Interfaces
{
    public interface IOutput<T>
    {
        public void Print(T product);
    }
}

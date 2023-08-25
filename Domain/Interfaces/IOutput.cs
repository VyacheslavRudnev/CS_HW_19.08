//using Woker = ConsoleApp190823.Domain.Models.Woker;

namespace ConsoleApp190823.Domain.Interfaces
{
    public interface IOutput<T>
    {
        public void Print(T woker);
    }
}

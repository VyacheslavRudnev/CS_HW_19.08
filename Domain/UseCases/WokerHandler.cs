using ConsoleApp190823.Domain.Interfaces;
using ConsoleApp190823.Domain.Models;

namespace ConsoleApp190823.Domain.UseCases
{
    public class WokerHandler : IOutput<Worker>
    {
        public void Print(Worker worker)
        { 
            worker.Print();        
        }
    }
}

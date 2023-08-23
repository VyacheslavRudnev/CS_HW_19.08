using ConsoleApp190823.Domain.Interfaces;

namespace ConsoleApp190823.Domain.Models
{
    public class Сurrency : ICurrency
    {
        public string MainPart { get; set; }
        public string FractPart { get; set; }
        public string Symbol { get; set; }
        public Сurrency()
        {
            MainPart = "USD";
            FractPart = "cent";
            Symbol = "$";
        }
        public Сurrency(string mainName, string symbol, string fractName)
        {
            MainPart = mainName;
            Symbol = symbol;
            FractPart = fractName;
           
        }
    }
}

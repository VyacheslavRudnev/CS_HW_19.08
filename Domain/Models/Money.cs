using ConsoleApp190823.Domain.Interfaces;

namespace ConsoleApp190823.Domain.Models
{
    public class Money : IMoneyValue
    {
        public decimal MainValue { get; set; }
        public decimal PartValue { get; set; }
        public ICurrency Currency { get; set; }

        public Money(decimal mainValue, decimal partValue, ICurrency currency)
        {
            MainValue = mainValue;
            PartValue = partValue;
            Currency = currency;
        }
        public override string ToString()
        {
            return $"валюта {Currency.MainPart}, ціна {MainValue} {Currency.Symbol} {PartValue} {Currency.FractPart}";
        }


       
    }
}

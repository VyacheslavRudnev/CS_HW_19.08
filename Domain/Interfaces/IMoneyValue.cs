namespace ConsoleApp190823.Domain.Interfaces
{
    public interface IMoneyValue
    {
        public decimal MainValue { get; set; }
        public decimal PartValue { get; set; }

        public ICurrency Currency { get; set; }
        //void Print();
        //void SetWholePart(int whole);
        //void SetFractionPart(int fraction);
    }
}

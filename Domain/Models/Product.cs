using ConsoleApp190823.Domain.Interfaces;


namespace ConsoleApp190823.Domain.Models
{
    public class Product : Money, IProduct
    {
        public string NameProduct { get; set; }
        public Product(string nameProduct, decimal mainValue, decimal partValue, ICurrency currency) : base(mainValue, partValue, currency)
        {
            NameProduct = nameProduct;
        }
        public override string ToString()
        {
            return $"{NameProduct}, {base.ToString()}";
        }
        public void PrintPrice()
        {
            Console.WriteLine($"{NameProduct}, {base.ToString()}");
        }
        public void ReducePrice(decimal mainValue, decimal fractValue)
        {
            MainValue -= mainValue;
            PartValue -= fractValue;            
        }
        public static Product operator -(Product product, decimal value)
        {
            product.MainValue -= value;
            return product;
        }
        public void SetPrice(decimal mainValue, decimal fractValue)
        {
            MainValue = mainValue;
            PartValue = fractValue;  
        }
    }
}

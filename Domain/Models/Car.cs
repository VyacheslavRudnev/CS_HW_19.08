using ConsoleApp190823.Domain.Interfaces;

namespace ConsoleApp190823.Domain.Models
{
    public class Car : Device, ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public string MaxSpeed { get; set; }

        public Car() { }
        
        public Car(string name, string type, string description, string color, string year, string brand, string model, string engine, string transmission, string fuelType, string maxSpeed)
            : base(name, type, description, color, year)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
            Transmission = transmission;
            FuelType = fuelType;
            MaxSpeed = maxSpeed;
        }
        public override string ToString()
        {
            return base.ToString() + $"Марка: {Brand} Модель: {Model}\nДвигун: {Engine} л. Трансмісія: {Transmission} Тип палива: {FuelType}\nМаксимальна швидкість: {MaxSpeed} км/год";
        }
        public override void Sound()
        {
            Console.WriteLine("Машина каже: Врум-врум-врум");
        }
        public override void Show()
        {
            Console.WriteLine($"Назва: {Name}\nТип: {Type}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Опис: {Description}\nХарактеристики:\nКолір: {Color}\nРік випуску: {Year}" +
                               $"\nМарка: {Brand} Модель: {Model}\nДвигун: {Engine} л., Трансмісія: {Transmission}, Тип палива: {FuelType}\nМаксимальна швидкість: {MaxSpeed} км/год");
        }

        
    }

}

using ConsoleApp190823.Domain.Interfaces;

namespace ConsoleApp190823.Domain.Models
{
    public class Device : IDevice
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public string Voice { get; set; }

       

        public Device() { }
        public Device(string name, string type, string description, string color, string year)
        {
            Name = name;
            Type = type;
            Description = description;
            Color = color;
            Year = year;
        }
        public override string ToString()
        {
            return $"Назва: {Name} Тип: {Type}\nОпис: {Description}\nХарактеристики:\nКолір: {Color} Рік випуску: {Year}";
        }
        public virtual void Sound()
        {
            Console.WriteLine($"Пристрій каже: ");
        }
        public virtual void Show()
        {
            Console.WriteLine($"Назва: {Name}\nТип: {Type}");
        }
        public virtual void Desc()
        {
            Console.WriteLine($"Опис: {Description}\nХарактеристики:\nКолір: {Color}, Рік випуску: {Year}");
        }
    }

}

using ConsoleApp190823.Domain.Interfaces;

namespace ConsoleApp190823.Domain.Models
{
    public class Teapot : Device, ITeapot
    {
        public string Trademark { get; set; }
        public string Material { get; set; }
        public string Volume { get; set; }
        public string PowerSupply { get; set; }

        public Teapot() { }
        public Teapot(string name, string type, string description, string color, string year, string trademark, string material, string volume, string powerSupply) : base(name, type, description, color, year)
        {
            Trademark = trademark;
            Material = material;
            Volume = volume;
            PowerSupply = powerSupply;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nТоргова марка: {Trademark}\nМатеріал: {Material}\nОб'єм: {Volume}\nЖивлення: {PowerSupply}";
        }
        public override void Sound()
        {
            Console.WriteLine("Чайник каже: псшсшсш");
        }
        public override void Show()
        {
            Console.WriteLine($"Назва: {Name}\nТип: {Type}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Опис: {Description}\nХарактеристики:\nКолір: {Color}\nРік випуску: {Year}" +
                $"\nТоргова марка: {Trademark}\nМатеріал: {Material}\nОб'єм: {Volume}\nЖивлення: {PowerSupply}");
        }


    }
}

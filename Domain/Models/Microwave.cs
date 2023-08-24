using ConsoleApp190823.Domain.Interfaces;

namespace ConsoleApp190823.Domain.Models
{
    public class Microwave : Device, IMicrowave
    {
        public string Trademark { get ; set ; }
        public string Power { get; set; }
        public Microwave() { }
        public Microwave(string name, string type, string description, string color, string year, string trademark, string power) : base(name, type, description, color, year)
        {
            Trademark = trademark;
            Power = power;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nТоргова марка: {Trademark}\nПотужність: {Power}";
        }
        public override void Sound()
        {
            Console.WriteLine("Мікрохвильовка каже: жжжжжжжж - дзинь");
        }
        public override void Show()
        {
            Console.WriteLine($"Назва: {Name}\nТип: {Type}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Опис: {Description}\nХарактеристики:\nКолір: {Color}\nРік випуску: {Year}" +
                               $"\nТоргова марка: {Trademark}\nПотужність: {Power}");
        }
    }
}

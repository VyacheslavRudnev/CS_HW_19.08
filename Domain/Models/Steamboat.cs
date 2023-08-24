using ConsoleApp190823.Domain.Interfaces;

namespace ConsoleApp190823.Domain.Models
{
    public class Steamboat : Device, ISteamboat
    {
        public string ClassBoat { get; set; }
        public string TypeBoat { get; set; }
        public string Displacement { get; set; }
        public string PassCapacity { get; set; }
        public string CargoCapacity { get; set; }

        public Steamboat() { }

        public Steamboat(string name, string type, string description, string color, string year, string classBoat, string typeBoat, string displacement, string passCapacity, string cargoCapacity)
            : base(name, type, description, color, year)
        {
            ClassBoat = classBoat;
            TypeBoat = typeBoat;
            Displacement = displacement;
            PassCapacity = passCapacity;
            CargoCapacity = cargoCapacity;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nКлас судна: {ClassBoat} Тип: {TypeBoat}" +
                $"\nВодотоннажність: {Displacement} т. Пасажиромісткість: {PassCapacity}\nВантаж: {CargoCapacity} т.";
        }

        public override void Sound()
        {
            Console.WriteLine("Пароплав каже: туу-туу-туууу");
        }
        public override void Show()
        {
            Console.WriteLine($"Назва: {Name}\nТип: {Type}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Опис: {Description}\nХарактеристики:\nКолір: {Color}\nРік випуску: {Year}" +
                        $"\nКлас судна: {ClassBoat}, Тип: {TypeBoat}" +
                        $"\nВодотоннажність: {Displacement} т., Пасажиромісткість: {PassCapacity}\n" +
                        $"Вантаж: {CargoCapacity} т.");
        }
    }
}

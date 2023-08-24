using ConsoleApp190823.Domain.Interfaces;

namespace ConsoleApp190823.Domain.Models
{
    public class Trombone : MusicInstrument, ITrombone
    {
        public string RangerMin { get; set; }
        public string RangerMax { get; set; }

        public Trombone() { }

        public Trombone(string name, string type, string subType, string rangerMin, string rangerMax) : base(name, type, subType)
        {
            RangerMin = rangerMin;
            RangerMax = rangerMax;
        }
        public override void Desc()
        {
            Console.WriteLine("Опис:");
            Console.WriteLine("Тромбон - музичний інструмент сімейства мідних духових інструментів з висувним трубопроводом.");
        }
        public override void History()
        {
            Console.WriteLine("Історія:");
            Console.WriteLine("Поява тромбона відноситься до XV століття. Прийнято вважати, що безпосередніми" +
                " попередниками цього інструменту були кулісні труби, при грі на яких музикант мав можливість" +
                " пересувати трубку інструменту, таким чином отримуючи хроматичний звукоряд.");
        }
        public override void Show()
        {
            Console.WriteLine($"Музичний інструмент:\n{Name}, клас {Type}, підклас {SubType}, діапазон {RangerMin} - {RangerMax}");
        }
        public override void Sound()
        {
            Console.WriteLine("Тромбон звучить: в диапазоні від Соль до Фа»"); ;
        }
    }
}

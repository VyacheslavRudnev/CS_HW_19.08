using ConsoleApp190823.Domain.Interfaces;

namespace ConsoleApp190823.Domain.Models
{
    public class Violin : MusicInstrument, IViolin
    {
        public string Register { get; set; }

        public Violin()
        {
            Register = "Violin";
        }
        public Violin(string name, string type, string subType, string register):base(name, type, subType)
        {
            Register = register;
        }
        public override void Desc()
        {
            Console.WriteLine("Опис:");
            Console.WriteLine("Скрипка — струнний музичний смичковий інструмент. Має чотири струни, які настроюють на квінту.\r\n");
        }
        public override void History()
        {
            Console.WriteLine("Історія:");
            Console.WriteLine("Прототипами скрипки були арабський ребаб і німецька рота, злиття яких і " +
                "утворило віолу. Форми скрипки сформувались до XVI століття; в цьому столітті і на початку " +
                "наступного, XVII, творили майстри скрипок сімейства Аматі.\r\n");
        }
        public override void Show()
        {
            Console.WriteLine($"Музичний інструмент:\n{Name}, клас {Type}, підклас {SubType}, регістр {Register}");
        }
        public override void Sound()
        {
            Console.WriteLine("Скрипка звучить: соль");
        }
    }
}

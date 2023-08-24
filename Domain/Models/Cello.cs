using ConsoleApp190823.Domain.Interfaces;

namespace ConsoleApp190823.Domain.Models
{
    public class Cello: MusicInstrument, ICello
    {
        public string Register { get; set; }
        public Cello() { }
        public Cello(string name, string type, string subType, string register) : base(name, type, subType)
        {
            Register = register;
        }

        public override void Desc()
        {
            Console.WriteLine("Опис:");
            Console.WriteLine("Віолончель — струнний смичковий музичний інструмент, родини скрипкових, " +
                "басо-тенорового регістру.\r\n");
        }
        public override void History()
        {
            Console.WriteLine("Історія:");
            Console.WriteLine("Поява віолончелі відноситься до початку XVI століття.\r\n");
        }
        public override void Show()
        {
            Console.WriteLine($"Музичний інструмент:\n{Name}, клас {Type}, підклас {SubType}, регістр {Register}");
        }

        public override void Sound()
        {
            Console.WriteLine("Віолончель звучить: басом");
        }
    }
    
}

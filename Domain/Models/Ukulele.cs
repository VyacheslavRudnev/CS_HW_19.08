using ConsoleApp190823.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Models
{
    internal class Ukulele : MusicInstrument, IUkulele 
    {
        public string Size { get; set; }
        public Ukulele() { }
        public Ukulele(string name, string type, string subType, string size) : base(name, type, subType)
        {
            Size = size;
        }
        public override void Desc()
        {
            Console.WriteLine("Опис:");
            Console.WriteLine("Укулеле - чотириструнний щипковий музичний інструмент.");
        }
        public override void History()
        {
            Console.WriteLine("Історія створення: Укулеле було створено в 1879 році в Гаваях.");
        }
        public override void Show()
        {
            Console.WriteLine($"Музичний інструмент:\n{Name}, клас {Type}, підклас {SubType}, розмір {Size}");
        }
        public override void Sound()
        {
            Console.WriteLine("Укулеле звучить дуже гармонійно.");
        }
    }
}

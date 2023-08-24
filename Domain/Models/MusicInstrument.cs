using ConsoleApp190823.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Models
{
    public class MusicInstrument : IMusicInstrument
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public MusicInstrument() { }
        public MusicInstrument(string name, string type, string subType)
        {
            Name = name;
            Type = type;
            SubType = subType;
        }
        public virtual void Desc()
        {
            Console.WriteLine("Музичний інструмент: ");
        }

        public virtual void History()
        {
            Console.WriteLine("Історія створення: ");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Музичний інструмент: {Name}, клас {Type}, підклас {SubType}");
        }

        public virtual void Sound()
        {
            Console.WriteLine("Інструмент звучить: ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Interfaces
{
    public interface IMusicInstrument
    {
        string Name { get; set; }
        string Type { get; set; }
        string SubType { get; set; }
        void Sound();
        void Show();
        void Desc();
        void History();
    }
}

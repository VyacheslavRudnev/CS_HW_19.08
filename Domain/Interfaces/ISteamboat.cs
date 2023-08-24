using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Interfaces
{
    public interface ISteamboat
    {
        string ClassBoat { get; set; }
        string TypeBoat { get; set; }
        string Displacement { get; set; }
        string PassCapacity { get; set; }
        string CargoCapacity { get; set; }
        string ToString();
        public void Sound()
        {
            Console.WriteLine("Пароплав каже: туу-туу-туууу");
        }   

    }
}

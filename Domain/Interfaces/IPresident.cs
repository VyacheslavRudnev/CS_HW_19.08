using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Interfaces
{
    public interface IPresident
    {
        int NumbersOfSubordinates { get; set; }
        void Print();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Interfaces
{
    public interface IWorker
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }

        public void Print();

    }
}

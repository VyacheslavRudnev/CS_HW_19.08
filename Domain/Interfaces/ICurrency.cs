using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Interfaces
{
    public interface ICurrency
    {
        public string MainPart { get; set; }
        public string FractPart { get; set; }
        public string Symbol { get; set; }
        
    }
}

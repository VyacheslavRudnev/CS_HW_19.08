using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Interfaces
{
    public interface IProduct
    {
        public string NameProduct { get; set; }
        void SetPrice(decimal mainValue, decimal fractValue);
        void PrintPrice();
        void ReducePrice(decimal mainValue, decimal fractValue);
    }
}

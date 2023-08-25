using ConsoleApp190823.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Models
{
    public abstract class Worker : IWorker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Worker() { }

        public Worker(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public abstract void Print();     
    }
    
}

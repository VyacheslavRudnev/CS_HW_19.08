using ConsoleApp190823.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Models
{
    public class Engineer:Worker,IEngineer
    {
        public string Function { get; set; }
        public Engineer() { }
        public Engineer(string name, string surname, int age, string function) : base(name, surname, age)
        {
            Function = function;
        }

        public override void Print()
        {
            Console.WriteLine("Інженер");
            Console.WriteLine($"{Name} {Surname}");
            Console.WriteLine($"Вік: {Age}");
            Console.WriteLine($"Головна фенкція: {Function}");
            Console.WriteLine("Проектує та розробляє продукти або рішення");
        }
    }
}

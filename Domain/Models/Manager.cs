using ConsoleApp190823.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Models
{
    public class Manager:Worker,IManager
    {
        public string Department { get; set; }
        public Manager() { }
        public Manager(string name, string surname, int age, string department) : base(name, surname, age)
        {
            Department = department;
        }
        public override void Print()
        {
            Console.WriteLine("Менеджер");
            Console.WriteLine($"{Name} {Surname}");
            Console.WriteLine($"Вік: {Age}");
            Console.WriteLine($"Підрозділ: {Department}");
            Console.WriteLine("Керує командами та проектами всередині компанії");
        }
    }
}

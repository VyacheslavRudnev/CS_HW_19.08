using ConsoleApp190823.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Models
{
    public class Security : Worker, ISecurity
    {
        public string TypeOfSecurity { get; set; }
        public Security() { }
        public Security(string name, string surname, int age, string typeOfSecurity) : base(name, surname, age)
        {
            TypeOfSecurity = typeOfSecurity;
        }
        public override void Print()
        {
            Console.WriteLine("Співробітник служби безпеки");
            Console.WriteLine($"{Name} {Surname}");
            Console.WriteLine($"Вік: {Age}");
            Console.WriteLine($"Зона відповідальності: {TypeOfSecurity}");
            Console.WriteLine("Забезпечує безпеку персоналу та внутрішніх даних чи інформації в компанії");
        }
    }
    
}

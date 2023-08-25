using ConsoleApp190823.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp190823.Domain.Models
{
    public class President : Worker, IPresident
    {
        public int NumbersOfSubordinates { get; set; }
        public President() { }
        public President(string name, string surname, int age, int numbersOfSubordinates) : base(name, surname, age)
        {
            NumbersOfSubordinates = numbersOfSubordinates;
        }
        public override void Print()
        {
            Console.WriteLine("Президент компанії");
            Console.WriteLine($"{Name} {Surname}");
            Console.WriteLine($"Вік: {Age}");
            Console.WriteLine($"Кількість підлеглих: {NumbersOfSubordinates}");
            Console.WriteLine("Відповідає за загальні рішення та напрямки розвитку компанії");
        }
    }
    
}

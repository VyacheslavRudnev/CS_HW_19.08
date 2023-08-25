using ConsoleApp190823.Domain.Models;
using ConsoleApp190823.Domain.UseCases;
using System.Text;

namespace ConsoleApp190823
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 4
            //Створити абстрактний базовий клас Worker(працівник)
            //з методом Print().Створіть чотири похідні класи: President,
            //Security, Manager, Engineer.Перевизначте метод.
            //Print() для виведення інформації, яка відповідає кож -
            //ному типу працівника.

            Console.WriteLine("HW/Mod06/ex04\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            President president = new President("Віктор", "Завгородній", 46, 1500);
            Security security = new Security("Василь", "Петренко", 35, "Внутрішня безпека");
            Manager manager = new Manager("Олександр", "Поревко", 35, "Відділ продажів");
            Engineer engineer = new Engineer("Віталій", "Ковальчук", 25, "Розробка програмного забезпечення");

            Worker[] workers = new Worker[] { president, security, manager, engineer };
            foreach (Worker worker in workers)
            {
                worker.Print();
                Console.WriteLine();
            }

            Console.WriteLine("\n\tВивід інформації з використанням WokerHandler-у\n\t");
            WokerHandler workerHandler = new WokerHandler();
            foreach (Worker worker in workers)
            {
                workerHandler.Print(worker);
                Console.WriteLine();
            }
        }
    }
}
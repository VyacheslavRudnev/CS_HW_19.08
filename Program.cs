using ConsoleApp190823.Domain.Interfaces;
using ConsoleApp190823.Domain.Models;
using ConsoleApp190823.Domain.UseCases;
using System.Text;

namespace ConsoleApp190823
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1
            //Запрограмуйте клас Money(об'єкт класу оперує однією
            //валютою) для роботи з грошима.
            //У класі мають бути передбачені: поле для зберігання
            //цілої частини грошей(долари, євро, гривні тощо) і поле
            //для зберігання копійок(центи, євроценти, копійки тощо)
            //Реалізувати методи виведення суми на екран, задання
            //значень частин.
            //На базі класу Money створити клас Product для роботи
            //з продуктом або товаром.Реалізувати метод, який дозволяє
            //зменшити ціну на задане число.
            //Для кожного з класів реалізувати необхідні методи і
            //поля.
            Console.WriteLine("HW/Mod06/ex01\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Product product = new Product("Хліб", 10, 50, new Сurrency("₴", "грн", "коп"));
            Console.WriteLine(product.ToString());

            Console.WriteLine("Встановлюємо нову вартість");
            product.SetPrice(20, 99);
            product.PrintPrice();
            Console.WriteLine("Зменшуємо вартість на 5 грн 50 коп");
            product.ReducePrice(5, 50);
            product.PrintPrice();

            Console.WriteLine("Зменшуємо вартість на 5 грн за допомогою перевантаженого оператора");
            Console.WriteLine($"{product - 5}");

            Console.WriteLine("\n");
            Console.WriteLine("Виводимо вартість за допомогою інтерфейсу");
            ProductHandler productHandler = new ProductHandler();
            productHandler.Print(product);
           

        }
    }

}
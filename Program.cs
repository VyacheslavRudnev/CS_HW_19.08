using ConsoleApp190823.Domain.Models;
using ConsoleApp190823.Domain.UseCases;
using System.Text;

namespace ConsoleApp190823
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 3
//Створити базовий клас «Музичний інструмент» і похідні
//класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». За
//допомогою конструктора, встановити назву до кожного
//музичного інструменту і його характеристики.
//Реалізуйте для кожного з класів методи:
//- Sound — видає звук музичного інструменту(пишемо
//текстом у консоль);
//- Show — відображає назву музичного інструменту;
//- Desc — відображає опис музичного інструменту;
//- History — відображає історію створення музичного
//інструменту.

            Console.WriteLine("HW/Mod06/ex03\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Violin violin = new Violin("Скрипка", "Струнний", "Смичковий", "Соль");
            Trombone trombone = new Trombone("Тромбон", "Духовий", "Мідні", "Соль", "Фа");
            Ukulele ukulele = new Ukulele("Укулеле", "Струнний", "Щипковий", "Сопрано");
            Cello cello = new Cello("Віолончель", "Струнний", "Смичковий", "Бас");

            MusicInstrument[] Instruments = new MusicInstrument[] { violin, trombone, ukulele, cello };
            foreach (MusicInstrument instrument in Instruments)
            {
                instrument.Show();
                instrument.Desc();
                instrument.History();
                instrument.Sound();
                Console.WriteLine();
            }
            Console.WriteLine("===============================================================================");
            Console.WriteLine("Використання інтерфейсу InstrumentHandler :\n");
            InstrumentHandler instrumentHandler = new InstrumentHandler();
            foreach (MusicInstrument instrument in Instruments)
            {
                instrumentHandler.Show(instrument);
                instrumentHandler.Desc(instrument);
                instrumentHandler.History(instrument);
                instrumentHandler.Sound(instrument);
                Console.WriteLine();
            }

        }
    }
}
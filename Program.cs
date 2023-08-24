using ConsoleApp190823.Domain.Models;
using ConsoleApp190823.Domain.UseCases;
using System.Text;

namespace ConsoleApp190823
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 2
//Створити базовий клас «Пристрій» і похідні класи:
//«Чайник», «Мікрохвильовка», «Автомобіль», «Пароплав».
//За допомогою конструктора, встановити назву до кожного
//пристрою і його характеристики.
//Реалізуйте для кожного з класів методи:
//* Sound — видає звук пристрою(пишемо текстом у
//консоль);
//* Show — відображає назву пристрою;
//* Desc — відображає опис пристрою.
            Console.WriteLine("HW/Mod06/ex02\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Teapot teapot = new Teapot("Чайник", "Побутовий прилад", "Пристрій для кип'ятіння води", "прозорий", "2019", "BROUN", "скло", "1.7", "220 v");
            Microwave microwave = new Microwave("Мікрохвильовка", "Побутовий прилад", "Пристрій для приготування їжі", "чорний", "2019", "LG", "2500 w");
            Car car = new Car("Автомобіль", "Транспортний засіб", "Пристрій для пересування по землі", "срібний", "2019", "BMW", "X5", "3.0", "автомат", "дизель", "280");
            Steamboat steamboat = new Steamboat("Пароплав", "Транспортний засіб", "Пристрій для пересування по воді", "білий", "2015", "Круїзний лайнер", "яхта", "10000", "1000", "22000");

            Device[] devices = new Device[] { teapot, microwave, car, steamboat };
            foreach (Device d in devices)
            {
                d.Show();
                d.Desc();
                d.Sound();
                Console.WriteLine();
            }

            DeviceHandler deviceHandler = new DeviceHandler();
            Console.WriteLine("Вивід інформації через DeviceHandler \n");
            deviceHandler.Show(teapot);
            deviceHandler.Description(teapot);
            deviceHandler.Sound(teapot);
            Console.WriteLine();
            deviceHandler.Show(microwave);
            deviceHandler.Description(microwave);
            deviceHandler.Sound(microwave);
            Console.WriteLine();
            deviceHandler.Show(car);
            deviceHandler.Description(car);
            deviceHandler.Sound(car);
            Console.WriteLine();
            deviceHandler.Show(steamboat);
            deviceHandler.Description(steamboat);
            deviceHandler.Sound(steamboat);
            Console.WriteLine();

        }
    }
}
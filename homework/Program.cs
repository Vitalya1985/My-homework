using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            List<Car> cars = new List<Car>()
            {
                new Car {Mark = "BMW", Model = "X5", Colour = "black", Price = 15_000},
                new Car {Mark = "Mazda", Model = "RX-8", Colour = "red", Price = 20_000},
                new Car {Mark = "Lada", Model = "Kalina", Colour = "gray", Price = 4_000},
                new Car {Mark = "Reno", Model = "Sandero", Colour = "green", Price = 10_000},
                new Car {Mark = "Peugeot", Model = "207", Colour = "red", Price = 8_000}
            };
            Console.WriteLine("Все машины у которых цена  больше 10_000");
            Show(Car.PriceIsGreater(cars));

            Console.WriteLine("Все машины красного цвета");
            Show(Car.CarsInRed(cars));

            Console.WriteLine("Выбрать все машины по заданной цене и марке машины");

            Show(Car.GivenPrice_andBrand(cars, "green", 10_000));          

            Console.WriteLine("Вывести сумму стоимости всех машин");
            Console.WriteLine($"Сумма = {Car.Sum(cars)}");

            Console.WriteLine("Вывести сколько машин красного цвета");
            Console.WriteLine($"Колличество авто = {Car.HowManyCars(cars)}");

            Console.WriteLine("Выбрать все дешевые машины (цена < 10_000)");
            var res = Car.CheapCars(cars).Select(c=>(c.Mark, c.Model));
            foreach (var item in res)
            {
                Console.WriteLine($"Авто: {item}");
            }

            Console.WriteLine("Выбрать все машины(по цене) в диапазоне");
            var tmp = Car.SelectAllCars(cars, 8_000, 20_000);
            Show(tmp.res);
            Console.WriteLine($"Количество красных авто = {tmp.count_red}  " +
                $"Количество черных авто = {tmp.count_black}");

            Console.Read();
        }
        static void Show(List<Car> cars)
        {
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Car
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Colour { get; set; }

        public override string ToString()
        {
            return $"Mark: {Mark}, Model: {Model}, Colour: {Colour}, Price: {Price}";
        }
        //Выбрать все машины у которых цена  больше 10_000
        /// <summary>
        /// Select all cars whose price is greater than 10_000
        /// </summary>
        /// <param name="car">
        /// List
        /// </param>
        /// <exception cref="IList"> PriceIsGreater</exception>"
        /// <returns>return car list (List)</returns>
        public static List<Car> PriceIsGreater(List<Car> car)
        {
            if (car.Count < 1)
            {
                throw new ArgumentException("В колекции нет машин");
            }
            return (car.Where(c => c.Price > 10_000)).ToList(); 
        }
        //Выбрать все машины красного цвета
        /// <summary>
        /// Select all cars in red
        /// </summary>
        /// <param name="car">
        /// List
        /// </param>
        /// <exception cref="List{T}">CarsInRed</exception>
        /// <returns>return car list (List)</returns>
        public static List<Car> CarsInRed(List<Car> car)
        {
            if (car.Count < 1)
            {
                throw new ArgumentException("В колекции нет машин");
            }
            return (car.Where(c => c.Colour == "red")).ToList();
        }
        //Выбрать все машины по заданной цене и марке машины
        /// <summary>
        /// Select all cars for a given price and brand of car
        /// </summary>
        /// <param name="car">List</param>
        /// <param name="col">string</param>
        /// <param name="pr">decimal</param>
        /// <exception cref="List{T}">GivenPrice_andBrand</exception>
        /// <returns>return car list (List)</returns>
        public static List<Car> GivenPrice_andBrand(List<Car> car, string col, decimal pr)
        {           
            if (car.Count < 1)
            {
                throw new ArgumentException("В колекции нет машин");
            }
            return (car.Where(c => (c.Colour == col && c.Price == pr))).ToList();            
        }

        //Вывести сумму стоимости всех машин
        /// <summary>
        /// Print the sum of the cost of all machines
        /// </summary>
        /// <param name="car">List</param>
        /// <exception cref="List{T}">Sum</exception>
        /// <returns>return sum (decimal)</returns>
        public static decimal Sum(List<Car> car)
        {
            if (car.Count < 1)
            {
                throw new ArgumentException("В колекции нет машин");
            }
            return (car.Sum(c => c.Price));
        }

        //Вывести сколько машин красного цвета
        /// <summary>
        /// Print how many cars are red
        /// </summary>
        /// <param name="car">List</param>
        /// <exception cref="List{T}">HowManyCars</exception>
        /// <returns>return kol (int)</returns>
        public static int HowManyCars(List<Car> car)
        {
            int kol = 0;
            foreach (var item in car)
            {
                if (item.Colour == "red")
                    kol++;
            }            
            return kol;
        }

        //Выбрать все дешевые машины (цена < 10_000)
        /// <summary>
        /// all cheap cars 
        /// </summary>
        /// <param name="car">List</param>
        /// <exception cref="List{T}">CheapCars</exception>
        /// <returns>return car list (List)</returns>
        public static List<Car> CheapCars(List<Car> car)
        {
            if (car.Count < 1)
            {
                throw new ArgumentException("В колекции нет машин");
            }
            return (car.Where(c => c.Price < 10_000)).ToList();
        }

        //Выбрать все машины(по цене) в диапазоне заданным пользователем и посчитайте 
        //сколько машин красного, черного цвета.
        /// <summary>
        /// all cars (by price) in range
        /// </summary>
        /// <param name="car">List</param>
        /// <param name="pr1">int</param>
        /// <param name="pr2">int</param>
        /// <exception cref="List{T}">SelectAllCars</exception>
        /// <returns>return car list (List)</returns>
        /// <returns>return number of red (int)</returns>
        /// <returns>return number of black (int)</returns>
        public static (List<Car> res, int count_red, int count_black) SelectAllCars(List<Car> car, decimal pr1, decimal pr2)
        {
            if (car.Count < 1)
            {
                throw new ArgumentException("В колекции нет машин");
            }
            int count_red = 0;
            int count_black = 0;
            var res = (car.Where(c => c.Price > pr1 && c.Price < pr2)).ToList();
            foreach (var item in res)
            {
                if (item.Colour == "red")
                    count_red++;
                if (item.Colour == "black")
                    count_black++;
            }
            return (res, count_red, count_black);
        }
    }
}

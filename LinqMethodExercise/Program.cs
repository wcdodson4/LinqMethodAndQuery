using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {   
            var videoGames = new List<string> { "FIFA", "Modern Warfare", "Wii Sports" };
            //Method Syntax Games
            var methodGames = videoGames.OrderBy(game => game.Length);
            foreach (var i in methodGames)
            {
                Console.WriteLine(i);
            }
            //Query Syntax Games
            var queryGames = from game in videoGames
                             orderby game.Length descending
                             select game;
            foreach (var g in queryGames)
            {
                Console.WriteLine(g);
            }

            List<string> cars = new List <string> { "Maserati", "Chevrolet", "Ferrari", "Lamborghini", "Ford", "Aston Martin" };
            //Query Syntax Cars
            var carWithI = from car in cars
                           where car.Contains("i")
                           orderby car descending
                           select car;
            foreach (var c in carWithI)
            {
                Console.WriteLine(c);
            }
        }
    }
}

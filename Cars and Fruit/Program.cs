using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Fruit
{
    class Program
    {
        string color = "red";
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "White", 2021, 100);
            Car Opel = new Car("Astra", "Blue", 2020, 120);
            Car Volvo = new Car("XC-90");
            Fruit Apple = new Fruit("Apple", "Red", 100, "Round");
            Fruit Watermelon = new Fruit("Watermelon", "Green", 1000, "Oval");
            Fruit Pineapple = new Fruit("Pineapple","Yellow", 550, "Rectangle");
            Ford.fullThrottle();
            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.color);
            Opel.fullThrottle();
            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.year);
            Console.WriteLine(Opel.color);
            Volvo.fullThrottle();
            Console.WriteLine(Volvo.name);
            Apple.fullThrottle();
            Console.WriteLine(Apple.name);
            Console.WriteLine(Apple.shape);
            Console.WriteLine(Apple.color);
            Watermelon.fullThrottle();
            Console.WriteLine(Watermelon.name);
            Console.WriteLine(Watermelon.shape);
            Console.WriteLine(Watermelon.color);
            Pineapple.fullThrottle();
            Console.WriteLine(Pineapple.name);
            Console.WriteLine(Pineapple.shape);
            Console.WriteLine(Pineapple.color);
            Console.ReadKey();
        }
    }
}

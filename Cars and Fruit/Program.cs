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
            Console.ReadKey();
        }
    }
}

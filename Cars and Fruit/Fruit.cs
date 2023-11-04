using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Fruit
{
    public class Fruit
    {
        public string color;
        public string name;
        public int weight;
        public string shape;

        public Fruit(string nameName, string colorName, int weightValue, string shapeName)
        {
            name = nameName;
            color = colorName;
            weight = weightValue;
            shape = shapeName;
        }
        public Fruit(string nameName)
        {
            name = nameName;
        }
        public void fullThrottle()
        {
            Console.WriteLine(name + " weights " + weight+"g");
        }
    }
}
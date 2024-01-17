using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Fruit
{
    public class Vehicle
    {
        public string engine_type = "gas";

        protected string color;
        protected string name;
        protected int maxSpeed; 
        protected int year;

        public string Name
        { 
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Year
        {
            get { return year; }
            
            set
            {
                if (value < 1980)
                {
                    throw new Exception("Please pass a correct value");
                }
                else
                {
                    year = value;
                }
            }
        }


        public void honk()            
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
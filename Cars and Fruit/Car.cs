using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cars_and_Fruit
{
    public class Car : Vehicle
    {
        private int carSeats;
        
        public int CarSeats { get; set; }

        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue, int carSeatsNo) : base(nameName, colorName, yearValue, maxSpeedValue)
        {
            carSeats = carSeatsNo;
        }

        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue, string eng_type, int carSeatsNo) : base(nameName, colorName, yearValue, maxSpeedValue, eng_type)
        {
            carSeats = carSeatsNo;
        }
        public Car(string nameName, int carSeatsNo) : base(nameName)
        {
            carSeats = carSeatsNo;
        }
        public void fullThrottle()
        {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }

    }
}
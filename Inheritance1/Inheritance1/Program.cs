using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class vehicle
        {
            public string name;
            public string make;
            public string color;
            public int price;


            public void addCar(string name, string make, string color, int price)
            {
                this.name = name;
                this.make = make;
                this.color = color;
                this.price = price;
            }

            public void addBike(string name, string make, string color, int price)
            {
                this.name = name;
                this.make = make;
                this.color = color;
                this.price = price;
            }

        }

        public sealed class Car: vehicle
        {
            Car myBigCar = new vehicle();
            
            
        }

        public sealed class MotorBike: vehicle
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1ClassesObjectsAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating an object, a new instance of Car is created called myCar
            Car myCar = new Car();
            myCar.name = "BMW";
            //instantiating an object, a new instance of Car is created called yourCar
            Car yourCar = new Car();
            yourCar.name = "Wheelchair";
            //instantiating an object, a new instance of Car is created called theirCar
            Car theirCar = new Car();
            theirCar.color = "shite color";

            Console.WriteLine("my car is a " + myCar.name);
            Console.WriteLine("your car is a " + yourCar.name);
            Console.WriteLine("thier car color is a " +theirCar.color);
            Console.WriteLine("car Objects instantiated " + Car.carObjects);
            Console.ReadLine();
        }
            
        //created a public class Car, avaialbel to be accessed by other classes wthin the project
        class Car
        {
            //declared private string variables/fields
            public string color;
            public string make;
            public string name;
            public int price;

            //created a constructor where I can count the increments of instances created from this class
            public Car()
            {
                carObjects++;
            }

            public static int carObjects;
        }
    }
}

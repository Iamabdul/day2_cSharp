using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticNonStaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating an object, a new instance of Car is created called myCar
            Car myCar = new Car();

            //the object myCar has given value to the property "name" which now holds the "BMW" string value to return when called upon etc etc.
            myCar.name = "BMW";
            myCar.make = "series";
            myCar.price = 20000;

            //created another new instance of the car class, created a car object named "car1"
            Car car1 = new Car();

            //used the instance method to call the AddCar method, inserted the given parameters in order of the list below
            car1.AddCar("wheely make", "wheely name", 9000);



            //this shows a static instance of a method, using the CLASS METHOD approach to calling it
            Console.WriteLine("\ncar Objects instantiated " + Car.numberOfCars);
            car1.ListCar();
            myCar.ListCar();
            myCar.SoldCar(true, 15000);

            Console.WriteLine("\ncar Objects instantiated " + Car.numberOfCars);


            Console.ReadLine(); 
        }






        //created a public class Car, avaialbel to be accessed by other classes wthin the project
        class Car
        {
            //declared private string variables/fields
            public string name;
            public string make;
            public int price;
            public bool sold;

            //declaring the method of ~AddCAr with it's given parameters
            public void AddCar (string make, string name, int price)
            {
                this.make = make;
                this.name = name;
                this.price = price;
            }
            // the non static method, or instance method, is declared as ListCar, public being accessable to other classes, 
            //void being that it doesnt add anything just alters the information of the object according to it's own template.
            public void ListCar()
            {
                var carList = new List<string> { this.name, this.make};

                // Iterate through the list.
                foreach (var carL in carList)
                {
                    Console.Write(carL + "\n ");
                }
            }

            public void SoldCar(bool isSold, int price)
            {
                this.sold = isSold;
                this.price = price;

                //adjust stock levels, namely reducing the amount of stock showing, but not removing it from the database
                Car.numberOfCars--;
            }

            //created a constructor where I can count the increments of instances created from this class
            public Car()
            {
                numberOfCars++;
            }

            //static method, also called a CLASS METHOD, can be called in the class without using any object to instantiate it.
            public static int numberOfCars;
        }
    }
}

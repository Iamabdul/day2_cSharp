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

            Car myCar = new Car();

            
            myCar.name = "BMW";
            myCar.make = "series";
            myCar.price = 20000;

            //created another new instance of the car class, created a car object named "car1"
            Car car1 = new Car();
            Car car2 = new Car();

            //used the instance method to call the AddCar method, inserted the given parameters in order of the list below
            car1.AddCar("wheely make", "wheely name", 9000);
            car2.AddCar("yoyo make", "yoyo name", 23000);



            //this shows a static instance of a method, using the CLASS METHOD approach to calling it
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
            List<Car> carList = new List<Car> { };


            //declaring the method of ~AddCAr with it's given parameters
            public void AddCar(string make, string name, int price)
            {
                this.make = make;
                this.name = name;
                this.price = price;
            }
            //non static
            public void ListCar()
            {
                // Iterate through the list.
                foreach (var carL in carList)
                {
                    Console.Write(carL + " ");
                }
            }

            public void SoldCar(bool isSold, int price)
            {
                this.sold = isSold;
                this.price = price;

                Car.numberOfCars--;
            }

           

            public static int numberOfCars;
            public Car()
            {
                numberOfCars++;
            }

        }
    }
}

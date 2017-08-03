using System;
using System.Collections.Generic;

namespace classInheritance
{
    class Vehicle
    {
        public string make;
        public string model;
        public int price;

        public static int numberOfVehicles;

        public Vehicle(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;

            Vehicle.numberOfVehicles++;

        }

    }//end of vehicle class

    class Car : Vehicle
    {
        public int bhp;

        public static int numberOfCars;

        public Car(string make, string model, int price, int bhp) : base(make, model, price)
        {
            this.bhp = bhp;

            Car.numberOfCars++;

        }

        public static void ListCar(int count)

        {
            //display number of vehicles
            Console.WriteLine(" Number of car: " + count);

        }

        public void CarProp()

        {
            //display car properties
            Console.WriteLine("\t Make: " + this.make + "\n" + "\t Model: " + this.model + "\n" + "\t Price: " + this.price + "\n" + "\t BHP: " + this.bhp + "\n");

        }
    }//end of car class

    class Motorbike : Vehicle
    {
        public int cc;

        public static int numberOfMotorbikes;

        public Motorbike(string make, string model, int price, int cc) : base(make, model, price)
        {
            this.cc = cc;

            Motorbike.numberOfMotorbikes++;

        }

        public static void ListBike(int count)

        {
            //display number of vehicles
            Console.WriteLine(" Number of motorbikes: " + count);

        }

        public void BikeProp()

        {

            //display car properties
            Console.WriteLine("\t Make: " + this.make + "\n" + "\t Model: " + this.model + "\n" + "\t Price: " + this.price + "\n" + "\t BHP: " + this.cc + "\n");

        }

    }//end of motorbike class

    class Program
    {
        static void Main(string[] args)
        {

            Vehicle.numberOfVehicles = 0; Car.numberOfCars = 0; Motorbike.numberOfMotorbikes = 0;
            List<Vehicle> vehicleList = new List<Vehicle>();
            List<Car> carList = new List<Car>();
            List<Motorbike> motorbikeList = new List<Motorbike>();

            //add vehicles

            Car car1 = new Car("RollsRoyce", "Silver Cloud", 35000, 250);
            vehicleList.Add(car1); carList.Add(car1);

            Car car2 = new Car("BMW", "m3", 20000, 350);
            vehicleList.Add(car2); carList.Add(car2);

            Motorbike bike1 = new Motorbike("Yamaha", "who cares", 10000, 50);
            vehicleList.Add(bike1); motorbikeList.Add(bike1);

            Motorbike bike2 = new Motorbike("cool bike", "random", 7000, 125);
            vehicleList.Add(bike2); motorbikeList.Add(bike2);

            //display vehicles
            Console.WriteLine(" Summary of vehicle stock as follows: \n " + "\n Total amount of vehicles: " + Vehicle.numberOfVehicles + "\n");

            //break down of vehicles, cars, bikes
            Car.ListCar(carList.Count); Motorbike.ListBike(motorbikeList.Count);

            //car catologue
            Console.WriteLine(" \n Car catologue: \n");
            car1.CarProp(); car2.CarProp();

            //bike catologue
            Console.WriteLine(" \n Bike catologue: \n");
            bike1.BikeProp(); bike2.BikeProp();

            //buy and sell vehicles

            Console.WriteLine("Would you like to buy/sell any vehicles? Type B to buy, type S to sell. Alternatively, type X to exit.");
            char response1 = Convert.ToChar(Console.ReadLine().ToUpper());

            switch ("buy, sell or exit")
            {
                case ('B'):

                    Console.WriteLine("Are you interested in our Motorbike catologue or our Car catologue? Type M for Motorbike, type C for car. Alternatively, type X to exit.");
                    char response2 = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (response2 == 'C')

                    {
                        Console.WriteLine("Please enter a make:");
                        Console.WriteLine("Please enter a model:");
                        Console.WriteLine("Please enter a price:");
                        Console.WriteLine("Please enter a BHP:");

                        string make = Console.ReadLine();
                        string model = Console.ReadLine();
                        int price = Convert.ToInt32(Console.ReadLine());
                        int bhp = Convert.ToInt32(Console.ReadLine());

                        Car sale = new Car(make, model, price, bhp);
                    }
                  
                 break;                                
            }
        }
    }
}
            
    



using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car car1 = new Car()
            {
                Make = "Bmw",
                Model = "X5",
                Year = 2021,
                EngineNoise = "vrooom",
                HonkNoise = "Beep",
                IsDriveable = true,
            };

            Car car2 = new Car()
            {
                Make = "Bmw",
                Model = "iX",
                Year = 2022,
                EngineNoise = "...",
                HonkNoise = "Beeep",
                IsDriveable = false,
            };
            Car car3 = new Car()
            {
                Make = "Bmw",
                Model = "m3",
                Year = 2023,
                EngineNoise = "vroooooom",
                HonkNoise = "Beeeep",
                IsDriveable = true,
            };

            Console.WriteLine("---------------------Engine Noise---------------------");

            Console.WriteLine($"{car1.Make} {car1.Model} Engine Noise - {car1.MakeEngineNoise()}");
            Console.WriteLine($"{car2.Make} {car2.Model} Engine Noise - {car2.MakeEngineNoise()}");
            Console.WriteLine($"{car3.Make} {car3.Model} Engine Noise - {car3.MakeEngineNoise()}");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Car c1 = new Car()
            {
                Make = "Bmw",
                Model = "X5",
                Year = 2021,
                EngineNoise = "vrooom",
                HonkNoise = "Beep",
                IsDriveable = true,
            };

            Car c2 = new Car();

            c2.Make = "Bmw";
            c2.Model = "iX";
            c2.Year = 2022;
            c2.EngineNoise = "...";
            c2.HonkNoise = "Beeep";
            c2.IsDriveable = false;

            Car c3 = new Car(2023, "BMW", "m3", "vrooooooom", "Beeeep", true);


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var lot = new CarLot();
            lot.Cars.Add(car1);
            lot.Cars.Add(car2);
            lot.Cars.Add(car3);

            Console.WriteLine("\n\n---------------------Preferences of each car---------------------");

            foreach (var car in lot.Cars)
            {
                if (car == car1)
                {
                    Console.WriteLine($"Car 1: {car1.Make} {car1.Model} {car1.Year}");
                }
                if (car == car2)
                {
                    Console.WriteLine($"Car 2: {car2.Make} {car2.Model} {car2.Year}");
                }
                if (car == car3)
                {
                    Console.WriteLine($"Car 3: {car3.Make} {car3.Model} {car3.Year}");
                }
            }

        }
    }
}


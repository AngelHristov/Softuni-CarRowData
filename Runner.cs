﻿namespace P01_RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
//some changes
    public class Runner
    {
        private List<Car> cars;

        public Runner()
        {
            this.cars = new List<Car>();
        }

        public void Run()
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine()
                    ?.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Car car = CreateCar(parameters);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(y => y.TirePressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                PrintResult(fragile);
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250)
                    .Select(x => x.Model)
                    .ToList();

                PrintResult(flamable);
            }
        }

        private static Car CreateCar(string[] parameters)
        {
            string model = parameters[0];

            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            Engine engine = new Engine(engineSpeed, enginePower);

            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];
            Cargo cargo = new Cargo(cargoWeight, cargoType);

            double tire1Pressure = double.Parse(parameters[5]);
            int tire1age = int.Parse(parameters[6]);
            Tire firstTire = new Tire(tire1Pressure, tire1age);

            double tire2Pressure = double.Parse(parameters[7]);
            int tire2age = int.Parse(parameters[8]);
            Tire seconfTire = new Tire(tire2Pressure, tire2age);

            double tire3Pressure = double.Parse(parameters[9]);
            int tire3age = int.Parse(parameters[10]);
            Tire thirdTire = new Tire(tire3Pressure, tire3age);

            double tire4Pressure = double.Parse(parameters[11]);
            int tire4age = int.Parse(parameters[12]);
            Tire fourthTire = new Tire(tire4Pressure, tire4age);

            Car car = new Car(model, engine, cargo, firstTire, seconfTire, thirdTire, fourthTire);

            return car;
        }

        private static void PrintResult(List<string> cars)
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}

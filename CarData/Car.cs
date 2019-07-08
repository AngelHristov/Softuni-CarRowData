namespace P01_RawData
{
    using System.Collections.Generic;

    public class Car
    {
        private string model;

        public List<Tire> Tires { get; set; }

        public string Model
        {
            get
            { return this.model; }
            set
            { this.model = value; }
        }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Car(string model, Engine engine, Cargo cargo, Tire firstTire, Tire secondTire, Tire thirdTire, Tire fourthTire)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = new List<Tire>() { firstTire, secondTire, thirdTire, fourthTire };
        }
    }
}

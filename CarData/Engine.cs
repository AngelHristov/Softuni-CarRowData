namespace P01_RawData
{
    public class Engine
    {
        private int engineSpeed;
        private int enginePower;

        public int EngineSpeed
        {
            get
            {
                return this.engineSpeed;
            }
            set
            {
                engineSpeed = value;
            }
        }

        public int EnginePower
        {
            get
            {
                return this.enginePower;
            }
            set
            {
                this.enginePower = value;
            }
        }

        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
    }
}

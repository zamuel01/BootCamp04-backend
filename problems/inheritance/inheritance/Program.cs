using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            LandTransport toyota = new LandTransport("Toyota", 100, 8, 4);
            AirTranport boing = new AirTranport("Boing", 300, 600, 4);

            toyota.print();
            boing .print();
        }
    }
    class Transport
    {
        public string ability;
        public int speedLimit;
        public int peopleCapacity;
        public string brand;

        public Transport(string brand, string ability, int speedLimit, int peopleCapacity)
        {
            this.brand = brand;
            this.ability = ability;
            this.speedLimit = speedLimit;
            this.peopleCapacity = peopleCapacity;
        }

        public virtual void print()
        {
            Console.WriteLine(string.Format(" Brand = {0} \n " +
                "Ability = {1} \n " +
                "speedLimit = {2} km/h \n " +
                "peopleCapacity = {3}", this.brand, this.ability, this.speedLimit, this.peopleCapacity));
        }
    }

    class AirTranport : Transport
    {
        public int maximunHeight;

        public AirTranport(string brand, int speedLimit, int peopleCapacity, int maximunHeight) : 
            base(brand, "Flay", speedLimit, peopleCapacity)
        {
            this.maximunHeight = maximunHeight;
        }

        public override void print()
        {
            base.print();
            Console.WriteLine(string.Format(" Maximun Height = {0} \n", this.maximunHeight));
        }
    }
    class LandTransport : Transport
    {
        public int numerWheels;
        public LandTransport(string brand, int speedLimit, int peopleCapacity, int numerWheels) : 
            base(brand, "Handle on land", speedLimit, peopleCapacity)
        {
            this.numerWheels = numerWheels;
        }
        public override void print()
        {
            base.print();
            Console.WriteLine(string.Format(" Numer of Wheels= {0}\n", this.numerWheels));
        }
    }

    class AquaticTransport : Transport
    {
        public AquaticTransport(string brand, int speedLimit, int peopleCapacity) : 
            base(brand, "navigate", speedLimit, peopleCapacity)
        {

        }
        public override void print()
        {
            base.print();
        }
    }

}

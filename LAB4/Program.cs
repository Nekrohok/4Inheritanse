using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;

namespace LAB4
{
    public class Vehicle
    {
        public string? Color { get; set; }
        public string? Name { get; set; }
        public string? Engine { get; set; }
        public decimal? Speed { get; set; }
        public int EnginePower { get; set; }
        public string? Brand { get; set; }
        public override string ToString()
        {
            return $" Name: {Name} Brand: {Brand} Speed: {Speed}";
        }

    }
    public class Water_Vehicle : Vehicle
    {

        public string? Type { get; set; }
   

    }
    public class Float : Water_Vehicle
    {
        public string? Material { get; set; }
    }
    public class Ground_Vehicle : Vehicle
    {

        public string? Type { get; set; }

    }
    public class Jeep : Ground_Vehicle
    {
        public string? Modefication { get; set; }
    }
    public class Air_Vehicle : Vehicle
    {

        public string? Type { get; set; }

    }
    public class Helicopter : Ground_Vehicle
    {
        public string? Amount_of_propeller { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Water_Vehicle Float = new Water_Vehicle();
            Ground_Vehicle Car = new Ground_Vehicle();
            Air_Vehicle Helicopter = new Air_Vehicle();
            Float.Name = "Float";
            Float.Brand = "WaterFUN";
            Float.Speed = 2;

            Car.Name = "Zhigul";
            Car.Brand = "Lada";
            Car.Speed = 150;

            Helicopter.Name = "H175";
            Helicopter.Brand = "Airbus";
            Helicopter.Speed = 300;

            decimal? maxspeed = 0;
            Vehicle[] vehicles = { Float, Car, Helicopter };
            foreach (Vehicle v in vehicles) if (v.Speed > maxspeed) maxspeed = v.Speed;
            foreach (Vehicle v in vehicles) if (v.Speed == maxspeed) {Console.WriteLine("FASTEST VEHICLE: " + v.ToString()); }


        }
    }
}
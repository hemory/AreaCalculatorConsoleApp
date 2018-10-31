using System;
namespace YouVroomIVroom
{
    public class Nascar : Car
    {
        public int CarSpeed { get; set; }
        public string CarType { get; set; }

        public Nascar(string carMake, string vin)
        {
            CarMake = carMake;
            VIN = vin;
        }
    }
}

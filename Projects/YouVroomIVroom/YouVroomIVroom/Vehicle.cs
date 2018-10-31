using System;
namespace YouVroomIVroom
{
    public class Car
    {
        public string CarMake { get; set; }
        public string VIN { get; set; }


        public Car(string carMake, string vin)
        {
            CarMake = carMake;
            VIN = vin;
        }
    }
}

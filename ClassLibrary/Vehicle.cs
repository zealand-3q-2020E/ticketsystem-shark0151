using System;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        public string Licenseplate;
        public DateTime Date;

        /// <summary>
        /// Returns the price of the Car
        /// </summary>
        /// <returns></returns>
        public abstract double Price();
        

        /// <summary>
        /// Returns the Type of vehicke
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
    }

    public class Car : Vehicle
    {
        public override double Price()
        {
            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }

    public class MC : Vehicle
    {
        public override double Price()
        {
            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}

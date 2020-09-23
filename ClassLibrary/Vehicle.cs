using System;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        /// <summary>
        /// It's the license plate
        /// </summary>
        public string Licenseplate;
        /// <summary>
        /// It's the Date of the ticket
        /// </summary>
        public DateTime Date;
        /// <summary>
        /// Wether or not the costumer has a brobizz discount, bro
        /// </summary>
        public bool brobizz = false;

        public void SetLicensePlate(string plate)
        {
            if(plate.Length > 7)
            {
                throw (new ArgumentOutOfRangeException("Licenseplate"));
            }
            else
            {
                Licenseplate = plate;
            }
        }

        public void SetBro(bool NewBro)
        {
            brobizz = NewBro;
        }

        /// <summary>
        /// Returns the price of the vehicle with discounts
        /// </summary>
        /// <returns> price - discount </returns>
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
            return 240 - Convert.ToInt32(brobizz)*(240*5/100);
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
            return 125.0 - Convert.ToDouble(brobizz) * (125.0 * 5.0 / 100.0);
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}

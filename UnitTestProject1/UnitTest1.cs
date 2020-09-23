using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckCarPrice()
        {
            Car NewCar = new Car();
            Assert.AreEqual(240, NewCar.Price());
        }

        [TestMethod]
        public void CheckMCPrice()
        {
            MC NewCar = new MC();
            Assert.AreEqual(125, NewCar.Price());
        }

        [TestMethod]
        public void CheckCartype()
        {
            Car NewCar = new Car();
            Assert.AreEqual("Car", NewCar.VehicleType());
        }

        [TestMethod]
        public void CheckMCtype()
        {
            MC NewCar = new MC();
            Assert.AreEqual("MC", NewCar.VehicleType());
        }

        [TestMethod]
        public void CheckPlate()
        {
            MC NewCar = new MC();
            NewCar.SetLicensePlate("xxxxxxx");
            Assert.AreEqual("xxxxxxx", NewCar.Licenseplate);
        }

        [TestMethod]
        public void CheckPlate2()
        {
            MC NewCar = new MC();
            try
            {
                NewCar.SetLicensePlate("xxxxxxxxxxx");
            }
            catch(ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }
    }
}

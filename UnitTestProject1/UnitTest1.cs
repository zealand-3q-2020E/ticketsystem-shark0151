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

        public void CheckPlateFail()
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

        [TestMethod]
        public void CheckCarPriceBro()
        {
            Car NewCar = new Car();
            NewCar.SetBro(true);
            Assert.AreEqual(228, NewCar.Price(), 0.01);
        }

        [TestMethod]
        public void CheckMCPriceBro()
        {
            MC NewCar = new MC();
            NewCar.SetBro(true);
            Assert.AreEqual(118.75, NewCar.Price(), 0.01);
        }
    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}

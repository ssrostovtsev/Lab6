using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneTests {
    [TestClass]
    public class BatteryChargeLevelIncreasingByThreadTest {
        [TestMethod]
        public void ChargeLevelIncreasingByThreadTest() {
            //Arrange
            LiPoBattery battery = new LiPoBattery(5000, 3.7, 95);
            int expectedResult = 100;
            ChargerThread chargerThread = new ChargerThread(battery);
            //Act
            chargerThread.Start();
            Thread.Sleep(10);
            int actualResult = battery.ChargeLevel;
            chargerThread.Stop();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

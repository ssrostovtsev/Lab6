using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneTests {
    [TestClass]
    public class BatteryChargeLevelIncreasingByTaskTest {
        [TestMethod]
        public void ChargeLevelIncreasingByTaskTest() {
            //Arrange
            LiPoBattery battery = new LiPoBattery(5000, 3.7, 95);
            int expectedResult = 100;
            ChargerTask chargerTask = new ChargerTask(battery);
            //Act
            chargerTask.Start();
            Thread.Sleep(10);
            int actualResult = battery.ChargeLevel;
            chargerTask.Stop();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

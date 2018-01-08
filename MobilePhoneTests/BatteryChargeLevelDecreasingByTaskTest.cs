using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneTests {
    [TestClass]
    public class BatteryChargeLevelDecreasingByTaskTest {
        [TestMethod]
        public void ChargeLevelDecreasingByTaskTest() {
            //Arrange
            LiPoBattery battery = new LiPoBattery(5000, 3.7, 10);
            int expectedResult = 0;
            DischargerTask dischargerTask = new DischargerTask(battery);
            //Act
            dischargerTask.Start();
            Thread.Sleep(10);
            int actualResult = battery.ChargeLevel;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

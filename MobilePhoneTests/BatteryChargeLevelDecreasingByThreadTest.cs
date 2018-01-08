using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneTests {
    [TestClass]
    public class BatteryChargeLevelDecreasingByThreadTest {
        [TestMethod]
        public void ChargeLevelDecreasingByThreadTest() {
            //Arrange
            LiPoBattery battery = new LiPoBattery(5000, 3.7, 10);
            int expectedResult = 0;
            DischargerThread dischargerThread = new DischargerThread(battery);
            //Act
            dischargerThread.Start();
            Thread.Sleep(10);
            int actualResult = battery.ChargeLevel;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

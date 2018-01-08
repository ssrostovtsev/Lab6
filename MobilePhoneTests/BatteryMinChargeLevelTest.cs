using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhoneTests {
    [TestClass]
    public class BatteryMinChargeLevelTest {
        [TestMethod]
        public void MinChargeLevelTest() {
            //Arrange
            LiPoBattery battery = new LiPoBattery(5000, 3.7, -20);
            int expectedResult = 0;
            int actualResult = battery.ChargeLevel;
            //Act
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

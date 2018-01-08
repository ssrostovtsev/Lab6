using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhoneTests {
    [TestClass]
    public class BatteryMaxChargeLevelTest {
        [TestMethod]
        public void MaxChargeLevelTest() {
            //Arrange
            LiPoBattery battery = new LiPoBattery(5000, 3.7, 195);
            int expectedResult = 100;
            int actualResult = battery.ChargeLevel;
            //Act
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileFormWinForm;
using MobilePhone;

namespace MobilePhoneTests {
    [TestClass]
    public class OutputTest {
        [TestMethod]
        public void iPhoneHeadsetTest() {
            ///Arrange
            FakeOutput fakeOutput = new FakeOutput();
            iPhoneHeadset iPHeadset = new iPhoneHeadset(fakeOutput);
            string songName = "Test Artist - Test Song";
            string expectedWriteLineResult = "iPhoneHeadset sound: Test Artist - Test Song";
            //Act
            iPHeadset.Play(songName);
            string writeLinedResult = fakeOutput.WriteLineResult;
            //Assert
            Assert.AreEqual(writeLinedResult, expectedWriteLineResult);
        }
    }
}

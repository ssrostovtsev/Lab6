using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneClassLib;

namespace MobilePhoneTests {
    [TestClass]
    public class MessageAddedToStorage {
        [TestMethod]
        public void MessageAddedTest() {
            //Arrange
            MessageStorage messageStorage = new MessageStorage("+380971994730");
            SMSGenerator sMSGenerator = new SMSGenerator();
            //Act
            sMSGenerator.GenerateMessage(messageStorage);
            int expectedResult = 1;
            List<Message> messages = messageStorage.GetAllMessages();
            int actual = messages.Count;
            //Assert
            Assert.AreEqual(expectedResult, actual);
        }
    }
}

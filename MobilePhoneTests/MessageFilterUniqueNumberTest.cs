using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneClassLib;

namespace MobilePhoneTests {
    [TestClass]
    public class MessageFilterUniqueNumberTest {
        [TestMethod]
        public void FilterUniqueNumberTest() {
            //Arrange
            List<Message> messages = new List<Message>();
            messages.Add(new Message("+3801", "+38 777", $"Message #1"));
            messages.Add(new Message("+3802", "+38 777", $"Message #2"));
            messages.Add(new Message("+3802", "+38 777", $"Message #3"));
            messages.Add(new Message("+3803", "+38 777", $"Message #4"));
            messages.Add(new Message("+3802", "+38 777", $"Message #5"));
            List<Message> expectedResult = new List<Message>();
            expectedResult.Add(new Message("+3801", "+38 777", $"Message #1"));
            expectedResult.Add(new Message("+3802", "+38 777", $"Message #2"));
            expectedResult.Add(new Message("+3803", "+38 777", $"Message #4"));
            //Act
            MessageFilter messageFilter = new MessageFilter();
            List<Message> filteredMessages = messageFilter.UniqueNumbers(messages);
            //Assert
            for (int i = 0; i < 3; i++) {
                Assert.AreEqual(expectedResult[i].SenderNumber, filteredMessages[i].SenderNumber);
            }
            ////CollectionAssert.AreEquivalent(expectedResult, filteredMessages);
        }
    }
}

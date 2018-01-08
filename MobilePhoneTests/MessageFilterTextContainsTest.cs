using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhoneTests {
    [TestClass]
    public class MessageFilterTextContainsTest {
        [TestMethod]
        public void FilterTextContainsTest() {
            //Arrange
            List<Message> messages = new List<Message>();
            messages.Add(new Message("+3801", "+38 777", $"Message #1"));
            messages.Add(new Message("+3802", "+38 777", $"Message #2"));
            messages.Add(new Message("+3802", "+38 777", $"Message #22"));
            messages.Add(new Message("+3803", "+38 777", $"Message #4"));
            messages.Add(new Message("+3802", "+38 777", $"Message #5"));
            List<Message> expectedResult = new List<Message>();
            expectedResult.Add(new Message("+3802", "+38 777", $"Message #2"));
            expectedResult.Add(new Message("+3802", "+38 777", $"Message #22"));
            //Act
            MessageFilter messageFilter = new MessageFilter();
            List<Message> filteredMessages = messageFilter.TextContains(messages, "#2");
            //Assert
            for (int i = 0; i < 2; i++) {
                Assert.AreEqual(expectedResult[i].Text, filteredMessages[i].Text);
            }
        }

    }
}

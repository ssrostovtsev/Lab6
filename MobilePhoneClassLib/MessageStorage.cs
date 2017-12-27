using System.Collections.Generic;

namespace MobilePhoneClassLib {
    public class MessageStorage {
        public MessageStorage(string phoneNo) {
            MyNumber = phoneNo;
            Messages = new List<Message>();
        }
        private string MyNumber;
        private List<Message> Messages { get; set; }
        public List<Message> GetAllMessages() {
            return Messages;
        }
        public void AddMessage(Message msg) {
            if (MyNumber == msg.ReceiverNumber) {
                Messages.Add(msg);
            }
        }
        public void DeleteMessage(string senderNo) {
            foreach (Message msg in Messages) {
                if (msg.SenderNumber == senderNo) {
                    Messages.Remove(msg);
                }
            }
        }
    }
}

using System.Collections.Generic;

namespace MobilePhoneClassLib {
    public class MessageStorage {
        public delegate void MessageHandler(object sender, MessageEventArgs e);
        public event MessageHandler MessageAdded;
        public event MessageHandler MessageDeleted;
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
                if (MessageAdded != null) {
                    MessageAdded(this, new MessageEventArgs(msg));
                }
            }
        }
        public void DeleteMessage(Message message) {
            for (int i = Messages.Count - 1; i >= 0; i--) {
                if (Messages[i].SenderNumber == message.SenderNumber) {
                    if (MessageDeleted != null) {
                        MessageDeleted(this, new MessageEventArgs(Messages[i]));
                    }
                    Messages.RemoveAt(i);
                }
            }
        }
    }
}

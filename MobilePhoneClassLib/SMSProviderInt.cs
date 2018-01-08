
using System.Timers;
using System.Windows.Forms;

namespace SimCorp.IMS.MobilePhoneClassLib {
    internal class SMSProviderInt {
        public SMSProviderInt(MessageStorage messageStorage) {
            SetAddSMSTimer(messageStorage);
            SetDelSMSTimer(messageStorage);
            Storage = messageStorage;
        }
        public delegate void SMSRecievedHandler(Message message);
        private MessageStorage Storage;
        private static void SetAddSMSTimer(MessageStorage messageStorage) {
            System.Timers.Timer addSMSTimer = new System.Timers.Timer(10000);
            addSMSTimer.Elapsed += (sender, e) => OnAddSMSTimedEvent(sender, e, messageStorage);
            addSMSTimer.AutoReset = true;
            addSMSTimer.Enabled = true;
        }
        private static void SetDelSMSTimer(MessageStorage messageStorage) {
            System.Timers.Timer delSMSTimer = new System.Timers.Timer(15000);
            delSMSTimer.Elapsed += (sender, e) => OnDelSMSTimedEvent(sender, e, messageStorage);
            delSMSTimer.AutoReset = true;
            delSMSTimer.Enabled = true;
        }
        private static Message SendSMS() {
            Message msg = new Message("+38000", "+380971994730", "SMS from Provider");
            return msg;
        }
        private static void OnAddSMSTimedEvent(object source, ElapsedEventArgs e, MessageStorage messageStorage) {
            Message msg = SendSMS();
            messageStorage.AddMessage(msg);
        }
        private static void OnDelSMSTimedEvent(object source, ElapsedEventArgs e, MessageStorage messageStorage) {
            messageStorage.DeleteMessage(new Message("+38000", "+00", "Messages from this number will be deleted!"));
        }

        private void AddMessageToStorage(MessageStorage storage, Message msg) {
            storage.AddMessage(msg);
        }
        private void DeleteMessageFromStorage(MessageStorage storage, Message msg) {
            storage.DeleteMessage(msg);
        }
    }
}


namespace MobilePhoneClassLib {
    internal class SMSProviderInt {
        public void AddMessageToStorage(MessageStorage storage, Message msg) {
            storage.AddMessage(msg);
        }
        public void DeleteMessageFromStorage(MessageStorage storage, Message msg) {
            storage.DeleteMessage(msg);
        }
    }
}


namespace SimCorp.IMS.MobilePhoneClassLib {
    public class SMSGenerator {
        public void GenerateMessage(MessageStorage storage) {
            Message msg = new Message("+38000", "+380971994730", "SMS from Generator");
            storage.AddMessage(msg);
        }

    }
}

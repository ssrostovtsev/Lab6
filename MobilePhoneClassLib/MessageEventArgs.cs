namespace SimCorp.IMS.MobilePhoneClassLib {
    public class MessageEventArgs {
        public Message Message { get; }
        public MessageEventArgs(Message message) {
            Message = message;
        }
    }
}

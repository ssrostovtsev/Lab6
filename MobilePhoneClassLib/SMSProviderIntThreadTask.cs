namespace SimCorp.IMS.MobilePhoneClassLib {
    public abstract class SMSProviderIntThreadTask {
        //public abstract Message SendSMS();
        public abstract void SendAddSMS();
        public abstract void Start();
        public abstract void Stop();
        public abstract void AddMessageToStorage(MessageStorage storage, Message msg);
        public abstract void DeleteMessageFromStorage(MessageStorage storage, Message msg);
    }
}

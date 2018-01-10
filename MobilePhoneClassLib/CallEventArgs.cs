namespace SimCorp.IMS.MobilePhoneClassLib {
    public class CallEventArgs {
        public Call Call { get; }
        public CallEventArgs(Call call) {
            Call = call;
        }
    }
}

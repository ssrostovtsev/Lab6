using SimCorp.IMS.MobilePhoneClassLib;
namespace SimCorp.IMS.MobilePhone {
    public class SimCorpMobile : Mobile {
        public SimCorpMobile(ScreenBase screen, BatteryBase battery, CPUBase cpu, MessageStorage messageStorage) : base(screen, battery, cpu, messageStorage) {
            Screen = screen;
            Battery = battery;
            CPU = cpu;
            SMSProviderInt = new SMSProviderInt(messageStorage);
        }
        public override ScreenBase Screen { get; set; }
        public override BatteryBase Battery { get; set; }
        public override CPUBase CPU { get; set; }
        internal override SMSProviderInt SMSProviderInt { get; set; }
    }
}

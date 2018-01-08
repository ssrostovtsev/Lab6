using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhoneClassLib {
    public class BatteryEventArgs {
        public int ChargeLevel { get; }
        public BatteryEventArgs(int chargeLevel) {
            ChargeLevel = chargeLevel;
        }
    }
}

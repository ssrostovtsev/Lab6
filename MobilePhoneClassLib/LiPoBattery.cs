namespace MobilePhone {
    public class LiPoBattery : BatteryBase {
        public LiPoBattery(int capacity, double voltage, int chargeLevel) : base(capacity, voltage, chargeLevel) { }
        public override string ToString() {
            return "LiPo Battery";
        }
    }
}

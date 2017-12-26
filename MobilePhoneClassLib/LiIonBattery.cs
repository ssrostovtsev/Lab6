namespace MobilePhone {
    public class LiIonBattery : BatteryBase {
        public LiIonBattery(int capacity, double voltage, int chargeLevel) : base(capacity, voltage, chargeLevel) { }
        public override string ToString() {
            return "LiIon Battery";
        }
    }
}

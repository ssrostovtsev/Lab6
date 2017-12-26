namespace MobilePhone {
    public abstract class BatteryBase {
        public BatteryBase() { }
        public BatteryBase(int capacity, double voltage, int chargeLevel) {
            this.Capacity = capacity;
            this.Voltage = voltage;
            this.ChargeLevel = chargeLevel;
        }
        public int Capacity { get; set; }
        public double Voltage { get; set; }
        public int ChargeLevel { get; set; }
    }
}

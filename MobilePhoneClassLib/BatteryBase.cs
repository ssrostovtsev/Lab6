using System.ComponentModel;
using SimCorp.IMS.MobilePhoneClassLib;

namespace SimCorp.IMS.MobilePhone {
    public abstract class BatteryBase {
        private int ChgLevel;
        public BatteryBase() { }
        public BatteryBase(int capacity, double voltage, int chargeLevel) {
            this.Capacity = capacity;
            this.Voltage = voltage;
            this.ChgLevel = chargeLevel;
        }
        public int Capacity { get; set; }
        public double Voltage { get; set; }
        public int ChargeLevel
        {
            get
            {
                if (ChgLevel > 100) {
                    ChgLevel = 100;
                }
                if (ChgLevel < 0) {
                    ChgLevel = 0;
                }
                return ChgLevel;
            }
            set
            {
                ChgLevel = value;
            }
        }
    }
}


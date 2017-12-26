using System;
namespace MobilePhone {
    public class WirelessCharger : ICharger {
        private IOutput Output;
        public WirelessCharger(IOutput output) {
            this.Output = output;
        }
        public void Charge(double voltage, double amperage) {
            Output.WriteLine($"{nameof(WirelessCharger)} wireless charge ({voltage} V, {amperage} A)");
        }
    }
}

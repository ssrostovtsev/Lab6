using System;
namespace MobilePhone {
    public class WireCharger : ICharger {
        private IOutput Output;
        public WireCharger(IOutput output) {
            this.Output = output;
        }
        public void Charge(double voltage, double amperage) {
            Output.WriteLine($"{nameof(WireCharger)} wire charge ({voltage} V, {amperage} A)");
        }
    }
}
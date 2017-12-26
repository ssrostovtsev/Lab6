namespace MobilePhone {
    public class SimCorpMobile : Mobile {
        public SimCorpMobile(ScreenBase screen, BatteryBase battery, CPUBase cpu) : base(screen, battery, cpu) {
            this.Screen = screen;
            this.Battery = battery;
            this.CPU = cpu;
        }
        public override ScreenBase Screen { get; set; }
        public override BatteryBase Battery { get; set; }
        public override CPUBase CPU { get; set; }
    }
}

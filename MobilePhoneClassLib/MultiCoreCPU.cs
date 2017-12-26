namespace MobilePhone {
    public class MultiCoreCPU : CPUBase {
        public MultiCoreCPU(string name, double frequency, int cores) : base(name, frequency, cores) {
            this.Cores = cores;
        }
        public override string ToString() {
            return this.Cores + " cores CPU";
        }
    }
}

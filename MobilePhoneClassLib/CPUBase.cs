namespace MobilePhone {
    public abstract class CPUBase {
        public CPUBase(string name, double frequency, int cores) {
            this.Name = name;
            this.Frequency = frequency;
            this.Cores = cores;
        }
        public string Name { get; set; }
        public double Frequency { get; set; }
        public int Cores { get; set; }
    }
}

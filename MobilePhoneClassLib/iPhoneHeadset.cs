namespace MobilePhone {
    public class iPhoneHeadset : IPlayback {
        private IOutput Output;
        public iPhoneHeadset(IOutput output) {
            this.Output = output;
        }
        public void Play(string data) {
            Output.WriteLine($"{nameof(iPhoneHeadset)} sound: {data}");
        }
    }
}
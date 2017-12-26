namespace MobilePhone {
    public class PhoneSpeaker : IPlayback {
        private IOutput Output;
        public PhoneSpeaker(IOutput output) {
            this.Output = output;
        }
        public void Play(string data) {
            Output.WriteLine($"{nameof(PhoneSpeaker)} sound: {data}");
        }
    }
}


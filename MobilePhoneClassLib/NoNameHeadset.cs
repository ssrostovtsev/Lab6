using System;
namespace MobilePhone {
    public class NoNameHeadset : IPlayback {
        private IOutput Output;
        public NoNameHeadset(IOutput output) {
            this.Output = output;
        }
        public void Play(string data) {
            Output.WriteLine($"{nameof(NoNameHeadset)} sound: {data}");
        }
    }
}
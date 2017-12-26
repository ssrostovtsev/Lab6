using MobilePhone;
namespace MobilePhoneClassLib {
    public class SamsungHeadset : IPlayback {
        private IOutput Output;
        public SamsungHeadset(IOutput output) {
            this.Output = output;
        }
        public void Play(string data) {
            Output.WriteLine($"{nameof(SamsungHeadset)} sound: {data}");
        }
    }
}

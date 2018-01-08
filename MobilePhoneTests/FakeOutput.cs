using SimCorp.IMS.MobilePhone;

namespace SimCorp.IMS.MobilePhoneTests {
    public class FakeOutput : IOutput {
        public string WriteResult { get; set; }
        public string WriteLineResult { get; set; }
        public void Write(string text) {
            WriteResult = text;
        }
        public void WriteLine(string text) {
            WriteLineResult = text;
        }
    }
}

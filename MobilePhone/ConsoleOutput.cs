using System;
using SimCorp.IMS.MobilePhone;

namespace MobilePhone {
    public class ConsoleOutput : IOutput {
        public void Write(string text) {
            Console.Write(text);
        }
        public void WriteLine(string text) {
            Console.WriteLine(text);
        }
    }
}

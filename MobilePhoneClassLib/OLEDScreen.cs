using System;

namespace MobilePhone {
    public class OLEDScreen : ColorfulScreen {
        public OLEDScreen(int width, int height) : base(width, height) { }
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(OLEDScreen)}");
            Console.WriteLine($"{screenImage.Data},({this.Width}X{this.Height})");
        }
        public override string ToString() {
            return "OLED Screen";
        }
    }
}

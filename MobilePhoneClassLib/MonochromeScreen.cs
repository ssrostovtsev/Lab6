using System;

namespace MobilePhone {
    public class MonochromeScreen : ScreenBase {
        public MonochromeScreen(int width, int height) : base(width, height) { }
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(MonochromeScreen)}");
            Console.WriteLine($"{screenImage.Data},({this.Width}X{this.Height})");
        }
        public override void Show(IScreenImage screenImage, int brightness) {
            Console.WriteLine($"I am {nameof(MonochromeScreen)}" + ", brightness is " + brightness);
        }
        public override string ToString() {
            return "Monochrome Screen";
        }
    }
}

using System;

namespace MobilePhone {
    public class ColorfulScreen : ScreenBase {
        public ColorfulScreen(int width, int height) : base(width, height) { }
        public override void Show(IScreenImage screenImage) {
            Console.WriteLine($"I am {nameof(ColorfulScreen)}");
            Console.WriteLine($"{screenImage.Data},({this.Width}X{this.Height})");
        }
        public override void Show(IScreenImage screenImage, int brightness) {
            Console.WriteLine($"I am {nameof(ColorfulScreen)}" + ", brightness is " + brightness);
        }
        public override string ToString() {
            return "Colorful Screen";
        }
    }

}

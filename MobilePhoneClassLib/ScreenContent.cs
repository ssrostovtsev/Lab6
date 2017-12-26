using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone {
    public class ScreenContent : IScreenImage {
        public ScreenContent(string screenData) {
            this.Data = screenData;
        }
        public string Data { get; set; }
    }
}

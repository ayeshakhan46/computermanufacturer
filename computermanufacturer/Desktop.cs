using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computermanufacturer
{
    class Desktop:computerbuilder
    {
        public Desktop()
        {
            computer = new computer();
        }

        public override void setcpu()
        {
            computer.cpu = "Intel Core i3";
        }

        public override void setRam()
        {
            computer.Ram = "13GB";
        }

        public override void setstorage()
        {
            computer.storage = "500GB SSD";
        }

        public override void setkeyboard()
        {
            computer.keyboard = "Standard Keyboard";
        }

        public override void setmouse()
        {
            computer.mouse = "Standard Mouse";
        }
    }
}

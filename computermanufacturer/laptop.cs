using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computermanufacturer
{
    class laptop : computerbuilder
    {
        public laptop()
         {
            computer = new computer();
         }

        public override void setcpu()
        {
            computer.cpu = "Intel Core i7";
        }

        public override void setRam()
        {
            computer.Ram = "16GB";
        }

        public override void setstorage()
        {
            computer.storage = "512GB SSD";
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

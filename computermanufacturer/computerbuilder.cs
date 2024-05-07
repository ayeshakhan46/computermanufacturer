using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computermanufacturer
{
   public abstract class computerbuilder
    {
        protected computer computer;
        public computer Computer
        {
            get 
            {
                return computer;
            }
        }

        public abstract void setcpu();
        public abstract void setmouse();
        public abstract void setkeyboard();
        public abstract void setRam();
        public abstract void setstorage();
    }
}

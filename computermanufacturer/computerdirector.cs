using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computermanufacturer
{
  public  class computerdirector
    {
        private computerbuilder computerbuilder;
        public computerdirector(computerbuilder cmp) 
        {
            this.computerbuilder = cmp;
        }
        public void constructcomputer() 
        {
            computerbuilder.setcpu();
            computerbuilder.setkeyboard();
            computerbuilder.setmouse();
            computerbuilder.setRam();
            computerbuilder.setstorage();
        }
        public computer GetComputer()
        {
            return computerbuilder.Computer;
        }
    }
}

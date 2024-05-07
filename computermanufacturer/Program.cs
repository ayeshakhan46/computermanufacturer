using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computermanufacturer
{
    class Program
    {
        static void Main(string[] args)
        {

            Desktop desktop = new Desktop();
            computerdirector director = new computerdirector(desktop);
            director.constructcomputer();
            computer desktopcomputer = director.GetComputer();
            Console.WriteLine(desktopcomputer);

            laptop laptop = new laptop();
            computerdirector director1 = new computerdirector(laptop);
            director1.constructcomputer();
            computer laptopcomputer = director1.GetComputer();
            Console.WriteLine(laptopcomputer);

            //singleinstance obj = singleinstance.getinstance();
            //singleinstance obj1 = singleinstance.getinstance();
            //obj.printmessage("hello");
            //obj1.printmessage("hi");
     
            
            


        }
    }
}

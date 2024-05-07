using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computermanufacturer
{
    public class singleinstance
    {
        private static singleinstance instance;
        private singleinstance() 
        {
        }
        public static singleinstance getinstance() 
        {
            if(instance == null) 
            {
                instance = new singleinstance();
            }
            return instance;
        }
        public void printmessage(string message) 
        {
            Console.WriteLine(message);
        }
    }
    
}

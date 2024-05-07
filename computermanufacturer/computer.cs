using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computermanufacturer
{
   public class computer
    {
        public string cpu { get; set; }
        public string Ram { get; set; }
        public string storage { get; set; }
        public string mouse { get; set; }
        public string keyboard { get; set; }
        public override string ToString()
        {
            return $"Computer with CPU: {cpu}, RAM: {Ram}, Storage: {storage}, Keyboard: {keyboard}, Mouse: {mouse}";
        }
    }
}

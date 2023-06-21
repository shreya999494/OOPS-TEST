using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    abstract class Smartphone
    {
        public abstract void Camera();
        public void Touchpad() 
        {
            Console.WriteLine("I am Touchpad");
        }
        public void Dualsim() 
        {       
            Console.WriteLine("I am Dualsim also");
        }
        void Speaker() 
        {
            Console.WriteLine("I am private Speaker");
        }
    }
}

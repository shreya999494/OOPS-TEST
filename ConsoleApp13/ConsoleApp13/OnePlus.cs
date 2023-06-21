using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class OnePlus : Smartphone, IOneplus7Series
    {
        override public void Camera()
        {
            Console.WriteLine("I am Camera!!!");
        }
        public void Os(string name)
        {
            Console.WriteLine("{0}",name);
        }
        public void NewFeature()
        {
            Console.WriteLine("I am OS of Oneplus7Series");
        }

        public void Os()
        {
            Console.WriteLine("I am new in Oneplus7Series");
        }
        /*public void Os() 
{
   Console.WriteLine("I am OS of Oneplus7Series");
}
public void NewFeature()   
{
   Console.WriteLine("I am new in Oneplus7Series");
}*/
    }
}

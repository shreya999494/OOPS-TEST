using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal partial class  Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = a;
            string  name = "I am Os" ; 

            UpdateValue(ref b);
            Console.WriteLine("final b : {0}", b);

            OnePlus onePlus = new OnePlus();
            onePlus.Os(name);
            onePlus.Camera();
            Nothing2 nothing2 = new Nothing2(); 
            nothing2.Camera(); 
            Nothing nothing =  new Nothing();
            nothing.Extra();
            nothing2.Touchpad();        
            Console.ReadKey();

        }
        
    }
}

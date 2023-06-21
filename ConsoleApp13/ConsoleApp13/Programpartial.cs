using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal partial class Program
    {

        static public int UpdateValue(ref int b)
        {
            b = 5;
            Console.WriteLine(" b : {0}", b);

            Console.ReadKey();
            return b;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Nothing2 : OnePlus, INothing1Series, INothing2Series 
    {
        public void AmoledDisplay()
        {
            throw new NotImplementedException();
        }

        public void Processor()
        {
            throw new NotImplementedException();
        }
    }
}

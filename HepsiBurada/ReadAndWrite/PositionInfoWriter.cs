using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.ReadAndWrite
{
    public class PositionInfoWriter : IWriter
    {
        public void Write()
        {
            Console.WriteLine("Enter rovers position info");
            Console.WriteLine("Sample position info looks like below");
            Console.WriteLine("0 1 N");
        }
    }
}

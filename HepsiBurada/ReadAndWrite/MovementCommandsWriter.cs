using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.ReadAndWrite
{
    public class MovementCommandsWriter : IWriter
    {
        public void Write()
        {
            Console.WriteLine("Enter rovers commands");
            Console.WriteLine("Sample position info looks like below");
            Console.WriteLine("LMRRLMRMMMLLLR");
        }
    }
}

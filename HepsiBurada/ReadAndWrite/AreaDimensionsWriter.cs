using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.ReadAndWrite
{
    public class AreaDimensionsWriter : IWriter
    {
        public void Write()
        {
            Console.WriteLine("Enter grids dimensions");
            Console.WriteLine("Sample grids dimensions looks like below");
            Console.WriteLine("5 5");
        }
    }
}

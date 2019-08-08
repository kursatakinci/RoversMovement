using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.ReadAndWrite
{
    public class StartupWriter : IWriter
    {
        public void Write()
        {
            Console.WriteLine("Welcome.");
        }
    }
}

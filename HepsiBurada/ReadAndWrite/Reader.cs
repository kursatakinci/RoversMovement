using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.ReadAndWrite
{
    public class Reader : IReader
    {
        public virtual string Read()
        {
            return Console.ReadLine();
        }
    }
}

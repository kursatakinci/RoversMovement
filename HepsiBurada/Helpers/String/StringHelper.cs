using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Helpers.String
{
    public static class StringHelper
    {
        public static string[] SplitStringIntoArray(string input, char seperator)
        {
            return input.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

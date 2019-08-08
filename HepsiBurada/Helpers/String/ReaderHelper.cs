using HepsiBurada.Helpers.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HepsiBurada.Helpers.String
{
    public static class ReaderHelper
    {
        public static List<int> GetIntegretValuesFromStringArray(string value)
        {
            string[] array = StringHelper.SplitStringIntoArray(value, ' ');
            return array.Select(a => AlwaysConvert.ToInt32(a)).ToList();
        }

        public static KeyValuePair<string, List<int>> GetRoverPosition(string value)
        {
            string[] array = StringHelper.SplitStringIntoArray(value, ' ');

            return new KeyValuePair<string, List<int>>(array.Last(), array.Where(a => a != array.Last()).Select(a => AlwaysConvert.ToInt32(a)).ToList());
        }
    }
}

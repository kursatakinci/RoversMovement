using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Helpers.Converters
{
    public static class AlwaysConvert
    {
        public static short ToInt16(object parseValue)
        {
            return ToInt16(parseValue, 0);
        }

        public static short ToInt16(object parseValue, short defaultValue)
        {
            short returnValue;

            try
            {
                if (!short.TryParse(parseValue.ToString(), out returnValue))
                {
                    returnValue = defaultValue;
                }
            }
            catch
            {
                returnValue = defaultValue;
            }

            return returnValue;
        }

        public static int ToInt32(object parseValue)
        {
            return ToInt32(parseValue, 0);
        }

        public static int ToInt32(object parseValue, int defaultValue)
        {
            int returnValue;

            try
            {
                if (!int.TryParse(parseValue.ToString(), out returnValue))
                {
                    returnValue = defaultValue;
                }
            }
            catch
            {
                returnValue = defaultValue;
            }

            return returnValue;
        }

        public static long ToLong(object parseValue)
        {
            return ToLong(parseValue, 0);
        }

        public static long ToLong(object parseValue, long defaultValue)
        {
            long returnValue;

            try
            {
                if (!long.TryParse(parseValue.ToString(), out returnValue))
                {
                    returnValue = defaultValue;
                }
            }
            catch
            {
                returnValue = defaultValue;
            }

            return returnValue;
        }

        public static double ToDouble(object parseValue)
        {
            return ToDouble(parseValue, 0);
        }

        public static double ToDouble(object parseValue, double defaultValue)
        {
            double returnValue;

            try
            {
                if (!double.TryParse(parseValue.ToString(), out returnValue))
                {
                    returnValue = defaultValue;
                }
            }
            catch
            {
                returnValue = defaultValue;
            }

            return returnValue;
        }

        public static byte ToByte(object parseValue)
        {
            return ToByte(parseValue, 0);
        }

        public static byte ToByte(object parseValue, byte defaultValue)
        {
            byte returnValue;

            try
            {
                if (!byte.TryParse(parseValue.ToString(), out returnValue))
                {
                    returnValue = defaultValue;
                }
            }
            catch
            {
                returnValue = defaultValue;
            }

            return returnValue;
        }

        public static Guid ToGuid(object parseValue)
        {
            return ToGuid(parseValue, Guid.Empty);
        }

        public static Guid ToGuid(object parseValue, Guid defaultValue)
        {
            Guid returnValue;

            try
            {
                if (!Guid.TryParse(parseValue.ToString(), out returnValue))
                {
                    returnValue = defaultValue;
                }
            }
            catch
            {
                returnValue = defaultValue;
            }

            return returnValue;
        }

        public static Decimal ToDecimal(object parseValue)
        {
            return ToDecimal(parseValue, 0);
        }

        public static Decimal ToDecimal(object parseValue, Decimal defaultValue)
        {
            Decimal returnValue;

            try
            {
                if (!Decimal.TryParse(parseValue.ToString(), out returnValue))
                {
                    returnValue = defaultValue;
                }
            }
            catch
            {
                returnValue = defaultValue;
            }

            return returnValue;
        }

        public static bool ToBool(object parseValue)
        {
            return ToBool(parseValue, false);
        }

        public static bool ToBool(object parseValue, bool defaultValue)
        {
            bool returnValue;

            try
            {
                if (!bool.TryParse(parseValue.ToString(), out returnValue))
                {
                    returnValue = defaultValue;
                }
            }
            catch
            {
                returnValue = defaultValue;
            }

            return returnValue;
        }

        public static object ToEnum(Type enumType, string parseValue, object defaultValue)
        {
            return ToEnum(enumType, parseValue, defaultValue, false);
        }

        public static object ToEnum(Type enumType, string parseValue, object defaultValue, bool ignoreCase)
        {
            try
            {
                return Enum.Parse(enumType, parseValue, ignoreCase);
            }
            catch
            {
                return defaultValue;
            }
        }

        public static string ToString(object parseValue)
        {
            return ToString(parseValue, string.Empty);
        }

        public static string ToString(object parseValue, string defaultValue)
        {
            if (parseValue == null || parseValue == DBNull.Value) return defaultValue;

            string returnValue;

            try
            {
                returnValue = parseValue.ToString();
            }
            catch
            {
                returnValue = defaultValue;
            }

            return returnValue;
        }

        public static DateTime ToDateTime(object parseValue, DateTime defaultValue)
        {
            DateTime returnValue;

            try
            {
                if (!DateTime.TryParse(parseValue.ToString(), out returnValue))
                {
                    returnValue = defaultValue;
                }
            }
            catch
            {
                returnValue = defaultValue;
            }

            return returnValue;
        }

        public static string ListToDelimitedString<T>(string delimiter, T[] array)
        {
            if (array == null || array.Length == 0) return string.Empty;

            var result = new List<string>();
            foreach (var item in array)
            {
                result.Add(item.ToString());
            }

            return string.Join(delimiter, result);
        }

        public static string ListToDelimitedString<T>(string delimiter, List<T> list)
        {
            if (list == null || list.Count == 0) return string.Empty;

            return ListToDelimitedString(delimiter, list.ToArray());
        }

        public static List<int> DelimitedStringToInt32List(string delimiter, string parseValue)
        {
            if (string.IsNullOrWhiteSpace(parseValue)) return new List<int>();

            var splittedValeus = parseValue.Split(delimiter.ToCharArray());

            var list = new List<int>();

            foreach (var value in splittedValeus)
            {
                list.Add(ToInt32(value, 0));
            }

            return list;
        }
    }
}

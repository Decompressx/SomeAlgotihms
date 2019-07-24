using System;
using System.Collections.Generic;
using System.Text;

namespace SomeAlgorithms
{
    public static class StringReverseExtension
    {
        public static string Reverse(this string str)
        {
            if (str == null)
                return null;

            char temp;
            int startStr = 0;
            int endStr = str.Length - 1;
            StringBuilder stringBuilder = new StringBuilder(str);

            while (startStr < endStr)
            {
                temp = stringBuilder[startStr];
                stringBuilder[startStr] = stringBuilder[endStr];
                stringBuilder[endStr] = temp;
                startStr++;
                endStr--;
            }

            return stringBuilder.ToString();
        }
    }
}

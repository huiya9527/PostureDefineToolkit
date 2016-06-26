using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostureDefinationToolkit
{
    class StringIntegerConverter
    {
        public static string convertToString(int number)
        {
            if (number >= 0 && number <= 9)
            {
                return number.ToString();
            }
            else if (number >= 10 && number <= 35)
            {
                char temp = (char)(number - 10 + 'A');
                return temp.ToString();
            }
            else if (number >= 36 && number <= 61)
            {
                char temp = (char)(number - 36 + 'a');
                return temp.ToString();
            }
            else if (number == 62)
            {
                char temp = '!';
                return temp.ToString();
            }
            else if (number == 63)
            {
                char temp = '?';
                return temp.ToString();
            }
            else
            {
                return null;
            }
        }

        public static int convertToInteger(string ss)
        {
            char temp = ss.ToCharArray()[0];
            if (temp >= '0' && temp <= '9')
            {
                return (int)(temp - '0');
            }
            else if (temp >= 'A' && temp <= 'Z')
            {
                return (int)(temp - 'A') + 10;
            }
            else if (temp >= 'a' && temp <= 'z')
            {
                return (int)(temp - 'a') + 36;
            }
            else if (temp == '1')
            {
                return 62;
            }
            else if (temp == '?')
            {
                return 63;
            }
            else
            {
                return int.MaxValue;
            }
        }
    }
}

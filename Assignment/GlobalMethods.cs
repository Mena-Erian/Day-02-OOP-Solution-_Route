using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public static class GlobalMethods
    {
        public static int GetIntFromUser(string massageToUser, bool isMainMsg = true)
        {
            int number = 0;
            switch (isMainMsg)
            {
                case true:
                    do
                    {
                        Console.Write(massageToUser);
                    }
                    while (!int.TryParse(Console.ReadLine(), out number));
                    break;
                case false:
                    do
                    {
                        Console.WriteLine($"Please Enter the {massageToUser}: ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out number));
                    break;
            }

            return number;
        }
        public static int GetIntFromUser(string dataName)
        {
            int number = 0;
            do
            {
                Console.Write($"Please Enter the {dataName}: ");
            }
            while (!int.TryParse(Console.ReadLine(), out number));
            return number;
        }
        public static string GetStringFromUser(string dataName)
        {
            string str = string.Empty;
            do
            {
                Console.WriteLine($"Please Enter the {dataName}: ");
                str = Console.ReadLine() ?? string.Empty;
            }
            while (str == string.Empty);

            return str;
        }
    }
}

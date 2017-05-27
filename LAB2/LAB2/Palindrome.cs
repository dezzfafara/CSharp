using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Palindrome
    {
        private string defaultString;
        private void SetString()
        {
            Console.WriteLine("Введите строку для проверки:");
            defaultString = Console.ReadLine().ToLower();
        }
        private string ReverseString(string str)
        {
            str.ToLower();
            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray);
            return new string(stringArray);
        }
        public bool PalindormeCheck()
        {
            SetString();
            if (defaultString == ReverseString(defaultString))
                return true;
            else
                return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class WordsCount
    {
        private string MySentence;
        private void SetString()
        {
            Console.WriteLine("Введите предложение:");
            MySentence = Console.ReadLine();
        }
        public uint CountWords()
        {
            SetString();
            uint count = 0;
            string[] split = MySentence.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            foreach( string str in split)
            {
                if (str.Trim() != "")
                    count++;
            }
            return count;
        }
    }
}

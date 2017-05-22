using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class ChangeRegister
    {
        private string inputData;
        private char Symbol;
        private void SetSymbol()
        {
            Console.WriteLine("Введите символ: ");
            inputData = Console.ReadLine();
            if (char.TryParse(inputData, out Symbol))
                Console.WriteLine("Успешная конвертация");
            else
                Console.WriteLine("Ошибка конвертации");
        }
        public char RegisterConverting()
        {
            SetSymbol();
            int temp;
            temp = (int)Symbol;
            if ((temp >= 1040 && temp <= 1071) || (temp >= 65 && temp <= 90))
                temp += 32;
            else if ((Symbol >= 1072 && Symbol <= 1103) || (Symbol >= 97 && Symbol <= 122))
                temp -= 32;
            Symbol = (char)temp;
            return Symbol;
        }
    }
}

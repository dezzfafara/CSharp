using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class ReverseNumber
    {
        private ulong number;
        private string inputData;
        private void SetNumber()
        {
            Console.WriteLine("Введите число:");
            inputData = Console.ReadLine();
            if (ulong.TryParse(inputData, out number))
                Console.WriteLine("Успешная конвертация");
            else
            {
                Console.WriteLine("Ошибка конвертации");
                return;
            }
        }
        public ulong Reverse()
        {
            ulong result = 0;
            SetNumber();
            while (number != 0)
            {
                result = result * 10 + number % 10;
                number /= 10;
            }
            return result;
        }
    }
}

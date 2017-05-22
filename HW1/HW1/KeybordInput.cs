using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class KeyboardInput
    {
        private string inputData;
        private int spacesQuantity;
        private char symbol;
        public int CountSpaces()
        {
            int count = 0;
            do
            {
                Console.WriteLine(@"Введите любой символ или '.' для выхода");
                inputData = Console.ReadLine();
                if (char.TryParse(inputData, out symbol))
                {
                    Console.WriteLine("Успешная конвертация.");
                    if (symbol == ' ')
                    {
                        count++;
                        spacesQuantity = count;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка конвертации");
                    return spacesQuantity;
                }
            } while (symbol != '.');

            return spacesQuantity;
        }

    }
}

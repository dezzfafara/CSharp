using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Pyramide
    {
        private int A, B;
        private string inputData;
        private void SetNumbers()
        {
            Console.WriteLine("Введите число А:");
            inputData = Console.ReadLine();
            if (int.TryParse(inputData, out A))
                Console.WriteLine("Успешная конвертация А");
            else
            {
                Console.WriteLine("Ошибка конвертации А");
                return;
            }
            Console.WriteLine("Введите число B:");
            inputData = Console.ReadLine();
            if (int.TryParse(inputData, out B))
                Console.WriteLine("Успешная конвертация B");
            else
            {
                Console.WriteLine("Ошибка конвертации B");
                return;
            }
            if (A >= B)
            {
                Console.WriteLine("А должно быть меньше В !!!!");
                return;
            }

        }
        public void ShowPyramide()
        {
            SetNumbers();
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(i);
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputData;
            var arr = new RangeOfArray(-4, 3);
            Console.WriteLine("Длина массива: " + arr.Length);
            for (int i = arr.GetMin(); i <= arr.GetMax(); i++)
            {
                Console.WriteLine("Введите " + i + "-й элемент:");
                InputData = Console.ReadLine();
                arr[i] = new Number { number = double.Parse(InputData) };
            }
            Console.WriteLine();
            for (int i = arr.GetMin(); i <= arr.GetMax(); i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

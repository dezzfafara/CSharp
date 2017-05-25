using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Array = new Arrays();
            Array.SetArrayB();
            Array.ShowArrayB();
            Array.SetArrayA();
            Array.ShowArrayA();
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент равен: " + Array.GetMaxArrayB());
            Console.WriteLine("Минимальный элемент равен: " + Array.GetMinArrayB());
            Console.WriteLine("Сумма всех элементов равна: " + Array.Summ());
            Console.WriteLine("Произведение всех элементов равно: " + Array.Multiply());
        }
    }
}

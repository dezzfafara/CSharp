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
            Console.WriteLine("Максимальный элемент равен: " + Array.GetMaxArrayB());
            Console.WriteLine("Приозведение всех элементов равно: " + Array.Multiply());
        }
    }
}

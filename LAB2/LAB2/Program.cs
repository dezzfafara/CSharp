using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//test!!!
namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise;
            string inputData;
            do
            {
                Console.WriteLine("Выберите дейтсвие:");
                Console.WriteLine("1 - расчеты для массивов; 2 - объединение общих элементов массивов; " +
                    "\n3 - проверка палиндрома; 4 - подсчет слов в предложении; \n5 - сумма между минимальным и максимальным элементами массива; 0 - выход");
                inputData = Console.ReadLine();
                if (int.TryParse(inputData, out choise))
                    Console.WriteLine("Успешная конвертация");
                else
                {
                    Console.WriteLine("Ошибка конвертации!!");
                    choise = 0;
                }
                switch (choise)
                {
                    case 1:
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
                        Console.WriteLine("Сумма четных элеметов массива А: " + Array.EvenSummA());
                        Console.WriteLine("Сумма элементов нечетных столбцов массива В: " + Array.OddColumnSummB());
                        break;
                    case 2:
                        var MergedArray = new ArraysMerging();
                        MergedArray.GetNewArray();
                        break;
                    case 3:
                        var palindrome = new Palindrome();
                        Console.WriteLine("ПАЛИНДРОМ ? :\n" + palindrome.PalindormeCheck());
                        break;
                    case 4:
                        var sentence = new WordsCount();
                        Console.WriteLine("Количество слов в предложении:" + sentence.CountWords());
                        break;
                    case 5:
                        var summMimMax = new DoubleDimensionArray();
                        Console.WriteLine("Сумма между минимальным и максимальным элементами массива: " + summMimMax.SummBetweenMinMax());
                        break;
                    default:
                        choise = 0;
                        break;
                }

            } while (choise != 0);
        }
    }
}

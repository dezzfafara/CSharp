using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise;
            string inputData;
            do
            {
                Console.WriteLine(@"Выберите действие:
1 - подсчет количества пробелов; 2 - определение счастиливого билета;
3 - изменение регистра; 4 - пирамида из чисел;
5 - реверс числа; 0 - выход.");
                inputData = Console.ReadLine();
                if (int.TryParse(inputData, out choise))
                    Console.WriteLine("Успешная конвертация");
                else
                {
                    Console.WriteLine("Ошибка конвертации!");
                    choise = 0;
                }
                switch (choise)
                {
                    case 1:
                        var input = new KeyboardInput();
                        Console.WriteLine("Количество введенных пробелов: " + input.CountSpaces());
                        break;
                    case 2:
                        var ticket = new LuckyTicket();
                        Console.WriteLine("Является ли билет счастливым?:" + ticket.IsLucky());
                        break;
                    case 3:
                        var convert = new ChangeRegister();
                        Console.WriteLine(convert.RegisterConverting());
                        break;
                    case 4:
                        var pyramide = new Pyramide();
                        pyramide.ShowPyramide();
                        break;
                    case 5:
                        var reverse = new ReverseNumber();
                        Console.WriteLine(reverse.Reverse());
                        break;
                    default:
                        choise = 0;
                        break;
                }
            } while (choise != 0);
        }
    }
}

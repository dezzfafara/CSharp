using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class LuckyTicket
    {
        private int ticketNumber;
        private string inputData;
        private int setTicketNumber()
        {
            Console.WriteLine("Введите номер билета (6 символов)");
            inputData = Console.ReadLine();
            if (int.TryParse(inputData, out ticketNumber))
                Console.WriteLine("Успешная ковертация");
            else
            {
                Console.WriteLine("Ошибка конвертации");
            }
            if (ticketNumber < 100000 || ticketNumber > 999999)
            {
                Console.WriteLine("Неправильно введен номер билета");
            }
            return ticketNumber;
        }
        public bool IsLucky()
        {
            int temp = setTicketNumber();
            int[] digits = new int[6];
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] = temp % 10;
                temp /= 10;
            }
            if ((digits[0] + digits[1] + digits[2]) == (digits[3] + digits[4] + digits[5]))
                return true;
            else
                return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery
{
    class Program
    {
        const int Size = 5;
        static void Main(string[] args)
        {
            double totalPrice = 0;
            Pencil[] pencil = new Pencil[Size];
            pencil[0] = new Pencil();
            pencil[1] = new Pencil(2.48, "Semiautomatic", "Green", "Agipa", true);
            pencil[2] = new Pencil(2.69, "Erich Krause", true);
            for (int i = 3; i < pencil.Length; i++)
            {
                pencil[i] = new Pencil();
                pencil[i].SetPrice();
                pencil[i].SetColor();
                pencil[i].SetForm();
                pencil[i].SetProducer();
                pencil[i].SetHasEraser();
            }
            for (int i = 0; i < pencil.Length; i++)
                pencil[i].ShowPencilInfo();

            Console.WriteLine("Количество карандашей: " + Pencil.GetQuantity());
            Pencil.CountTotalPrice(ref totalPrice);
            Console.WriteLine("Общая стоимость:" + totalPrice);
        }
    }
}

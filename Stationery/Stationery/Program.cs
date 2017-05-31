using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalprice = 0;
            Pencil[] pencil = new Pencil[10];
            pencil[0] = new Pencil();
            pencil[0].ShowPencilInfo();
            pencil[1] = new Pencil(1.33, "Erich Krause", true);
            pencil[1].ShowPencilInfo();
            pencil[2] = new Pencil(2.69, "Erich Krause", true);
            pencil[2].ShowPencilInfo();
            Console.WriteLine("Количество карандашей: " + Pencil.GetQuantity());
            Pencil.CountTotalPrice(ref totalprice);
            Console.WriteLine("Общая стоимость:" + totalprice);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class DoubleDimensionArray
    {
        const int sizeM = 5, sizeN = 5, indexSize = 3;
        private int MIN, MAX;
        private int[] Indexes = new int[indexSize];
        private int[,] MyArray = new int[sizeM, sizeN];
        private int[] TempArray = new int[sizeM * sizeN];
        private void SetAndShowMyArray()
        {
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    MyArray[i, j] = random.Next(1, 101);
                    TempArray[count] = MyArray[i, j];
                    count++;
                    Console.Write(MyArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        private void FindMinMaxIndexes()
        {

            MIN = MAX = MyArray[0, 0];

            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    if (MyArray[i, j] < MIN)
                        MIN = MyArray[i, j];

                    if (MyArray[i, j] > MAX)
                        MAX = MyArray[i, j];
                }
            }
            Indexes[0] = Array.LastIndexOf(TempArray, MIN);
            Indexes[1] = Array.IndexOf(TempArray, MAX);
            if (Indexes[1] < Indexes[0])
            {
                Indexes[2] = Indexes[1];
                Indexes[1] = Indexes[0];
                Indexes[0] = Indexes[2];
            }
            Console.WriteLine(MIN + " - " + MAX);
        }
        public long SummBetweenMinMax()
        {
            SetAndShowMyArray();
            FindMinMaxIndexes();

            long summ = 0;

            for (int i = Indexes[0] + 1; i < Indexes[1]; i++)
                summ += TempArray[i];
            return summ;
        }
    }
}

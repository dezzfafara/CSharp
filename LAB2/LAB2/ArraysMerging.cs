using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class ArraysMerging
    {
        private const int sizeM = 10, sizeN = 5;
        int[] arrayA = new int[sizeM];
        int[] arrayB = new int[sizeN];
        int[] arrayC = new int[sizeM + sizeN];
        int[] tempArray = new int[sizeM + sizeN];
        private void SetArrays()
        {
            Random random = new Random();
            for (int i = 0; i < arrayA.Length; i++)
                arrayA[i] = random.Next(1, 10);
            for (int i = 0; i < arrayB.Length; i++)
                arrayB[i] = random.Next(1, 10);
        }
        private void PushIntoArrayC()
        {
            int count = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    if (arrayA[i] == arrayB[j])
                    {
                        arrayC[count] = arrayA[i];
                        count++;
                    }
                }
            }
        }
        private void PushIntoTempArray()
        {
            int count = 0;
            Array.Copy(arrayC, tempArray, tempArray.Length);
            Array.Sort(tempArray);
            for (int i = 1; i < tempArray.Length; i++)
            {
                if (tempArray[i - 1] != tempArray[i])
                {
                    arrayC[count] = tempArray[i];
                    count++;
                }
            }
            Array.Resize(ref arrayC, count);
        }
        public void GetNewArray()
        {
            SetArrays();
            PushIntoArrayC();
            PushIntoTempArray();
            Console.WriteLine("Массив А:");
            for (int i = 0; i < arrayA.Length; i++)
                Console.Write(arrayA[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Массив В:");
            for (int i = 0; i < arrayB.Length; i++)
                Console.Write(arrayB[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Массив С:");
            for (int i = 0; i < arrayC.Length; i++)
                Console.Write(arrayC[i] + " ");
            Console.WriteLine();

        }
    }
}

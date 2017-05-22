using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Arrays
    {
        private double[] A = new double[5];
        private double[,] B = new double[3, 4];
        private double _MaxElement;
        public void SetArrayA()
        {
            string inputData;
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + "-й элемента массива А");
                inputData = Console.ReadLine();
                if (double.TryParse(inputData, out A[i]))
                    Console.WriteLine("Успешная конвертация. " + (i + 1) + "-му элементу массива A присвоено значение " + inputData.ToString());
                else
                {
                    Console.WriteLine("Ошибка конвертации. " + (i + 1) + "-му элементу массива A присвоено значение 0.00");
                    A[i] = 0.00;
                }
            }

        }
        private double GetElementByIndex(int index)
        {
            return A[index];
        }
        private double GetElementByIndex(int IIndex, int JIndex)
        {
            return B[IIndex, JIndex];
        }
        public void ShowArrayA()
        {
            for (int i = 0; i < A.Length; i++)
                Console.Write(GetElementByIndex(i) + " ");
        }
        public void SetArrayB()
        {
            Random random = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                    B[i, j] = Convert.ToDouble(random.Next(10000)) / 100;
            }
        }
        public void ShowArrayB()
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                    Console.Write(GetElementByIndex(i, j) + " ");
                Console.WriteLine();
            }
        }

        public double GetMaxArrayA()
        {
            _MaxElement = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > _MaxElement)
                    _MaxElement = A[i];
            }
            return _MaxElement;
        }
        public double GetMaxArrayB()
        {
            _MaxElement = GetMaxArrayA();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > _MaxElement)
                        _MaxElement = B[i, j];
                }
            }

            return _MaxElement;
        }
        public decimal Multiply()
        {
            decimal multiple = 1;
            for (int i = 0; i < A.Length; i++)
                multiple *= Convert.ToDecimal(A[i]);
            return multiple;
        }
    }
}
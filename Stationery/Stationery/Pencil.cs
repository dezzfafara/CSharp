using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery
{
    class Pencil
    {
        double _price;
        string _type, _color, _producer;
        bool _hasEraser;
        static int _totalQuantity;
        string inputData;
        public double GetPrice()
        {
            return _price;
        }
        public string GetType()
        {
            return _type;
        }
        public string GetColor()
        {
            return _color;
        }
        public string GetProducer()
        {
            return _producer;
        }
        public bool GetHasEraser()
        {
            return _hasEraser;
        }
        public void SetColor()
        {
            Console.WriteLine("Введите цвет:");
            _color = Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery
{
    partial class Pencil
    {
        double _price;
        string _form, _color, _producer;
        bool _hasEraser;
        static int _totalQuantity;
        static double _totalPrice;
        string inputData;
        static Pencil()
        {
            _totalQuantity = 0;
            _totalPrice = 0;
        }
        public Pencil()
        {
            _totalQuantity++;
            _price = 0.0;
            _form = "Simple";
            _color = "Grey";
            _producer = "Tukzar";
            _hasEraser = false;
            _totalPrice += _price;
        }
        public Pencil(double _price, string _form, string _color, string _producer, bool _hasEraser)
        {
            _totalQuantity++;
            this._price = _price;
            this._form = _form;
            this._color = _color;
            this._producer = _producer;
            this._hasEraser = _hasEraser;
            _totalPrice += this._price;
        }
        // constructor for non color not automatic pencil
        public Pencil(double _price, string _producer, bool _hasEraser)
        {
            _totalQuantity++;
            this._price = _price;
            this._form = "Simple";
            this._color = "Grey";
            this._producer = _producer;
            this._hasEraser = _hasEraser;
            _totalPrice += this._price;
        }
        public double GetPrice()
        {
            return _price;
        }
        public string GetForm()
        {
            return _form;
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
        public void SetPrice()
        {
            Console.WriteLine("Введите цену:");
            inputData = Console.ReadLine();
            if (double.TryParse(inputData, out _price))
                Console.WriteLine("Цена установлена");
            else
                Console.WriteLine("Ошибка конвертации");
            _totalPrice += this._price;
        }
        public void SetColor()
        {
            Console.WriteLine("Введите цвет:");
            _color = Console.ReadLine();
        }
        public void SetForm()
        {
            Console.WriteLine("Введите тип:");
            _form = Console.ReadLine();
        }
        public void SetProducer()
        {
            Console.WriteLine("Введите производителя:");
            _producer = Console.ReadLine();
        }
        public void SetHasEraser()
        {
            Console.WriteLine("Есть ли у данной модели ластик ?:");
            inputData = Console.ReadLine();
            if (bool.TryParse(inputData, out _hasEraser))
                Console.WriteLine("Наличие ластика установлено");
            else
            {
                Console.WriteLine("Ошибка конвертации!!");
                _hasEraser = false;
            }
        }
        public void ShowPencilInfo()
        {
            Console.WriteLine(GetPrice() + " - " + GetForm() + " - " + GetColor() + " - " + GetProducer() + " - " + GetHasEraser());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class RangeOfArray
    {
        private int _Min, _Max;
        private string _InputData;
        Number[] MyArray;
        public RangeOfArray(int _min, int _max)
        {
            _Min = _min;
            _Max = _max;
            MyArray = new Number[_Max - _Min + 1];
        }
        public Number this[int index]
        {
            get
            {
                if (index >= _Min && index <= _Max)
                {
                    return MyArray[index - _Min];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                MyArray[index - _Min] = value;
            }
        }
        public int Length
        {
            get
            {
                return MyArray.Length;
            }
        }

        public int GetMin()
        {
            return _Min;
        }
        public int GetMax()
        {
            return _Max;
        }
    }
}

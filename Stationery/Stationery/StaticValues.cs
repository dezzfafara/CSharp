using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationery
{
    partial class Pencil
    {
        public static int GetQuantity()
        {
            return _totalQuantity;
        }
        public static void CountTotalPrice(ref double totalprice)
        {
            totalprice = _totalPrice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    namespace Account
    {
        class Account
        {
            public double _Balance;
            private Guid _ID;
            private int _PIN;
            static Random rand = new Random();
            public Account()
            {
                _Balance = 0.0;
                _ID = Guid.NewGuid();
                _PIN = rand.Next(1000, 10000);
            }
            public override string ToString()
            {
                return "" + _ID + " :: " + _Balance + " :: " + _PIN;
            }
        }
    }
}

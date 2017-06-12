using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    namespace Client
    {
        class Client
        {
            private string _InputData;
            Account.Account[] ClientsAccounts;
            public Client(int size)
            {
                ClientsAccounts = new Account.Account[size];
                for (int i = 0; i < size; i++)
                {
                    ClientsAccounts[i] = new Account.Account();
                }
            }
            public int Length
            {
                get
                {
                    return ClientsAccounts.Length;
                }
            }
            public Account.Account this[int index]
            {
                get
                {
                    if (index >= 0 && index < ClientsAccounts.Length)
                        return ClientsAccounts[index];
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}

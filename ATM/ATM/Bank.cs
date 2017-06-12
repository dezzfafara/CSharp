using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = ATM.Account;
using C = ATM.Client;
namespace ATM
{
    namespace Bank
    {
        class Bank
        {
            static void Main(string[] args)
            {
                C::Client BankClients = new C::Client(1);
                for (int i = 0; i < BankClients.Length; i++)
                    Console.WriteLine(BankClients[i]);
                BankClients[0].SetBalance();
                Console.WriteLine(BankClients[0]);
            }
        }
    }
}

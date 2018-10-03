using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbuz
{
    public class Wallet
    {
        public int Amount { get; set; }
        public Wallet(int amount)
        {
            Amount = amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Sailors
{
    public class Person
    {
        public int Coins { get; set; }

        public void TakeCoins(IHoldCoins container, int amount)
        {
            Coins+= container.GetCoins(amount);
        }
        public int PutCoins(IHoldCoins container, int amount)
        {
            Coins-= container.PutCoins(amount);
            return amount;
        }
        public void ThrowCoins(int amount)
        {
            Coins -= amount;
        }
        public void GiveCoins(Person person, int amount)
        {
            Coins -= amount;
            person.Coins += amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Sailors
{
    public class Chest: IHoldCoins
    {
        public int Coins { get; }

        public Chest(int coins)
        {
            Coins = coins;
        }

        public int GetCoins(int amount)
        {
            Coins -= amount;
            return amount;
        }

        public int GetAllCoins()
        {
            return GetCoins(Coins);
        }

        public void PutCoins(int amount)
        {
            Coins += amount;
        }
    }
}

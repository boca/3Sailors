using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Sailors
{
    public interface IHoldCoins
    {
        public int GetCoins(int amount);
        public int GetAllCoins();
        public void PutCoins(int amount);
    }
}

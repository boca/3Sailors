using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Sailors
{
    public interface IHoldCoins
    {
        int GetCoins(int amount);
        int GetAllCoins();
        int PutCoins(int amount);
    }
}

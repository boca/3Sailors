using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Sailors
{

    public class Story
    {
        private int coins;

        public Story(int amount)
        {
            coins = amount;
        }
        public bool AmountWorks()
        {
            Chest chest = new Chest(coins);
            Person sailor1 = new Person();
            Person sailor2 = new Person();
            Person sailor3 = new Person();
            Person taxCollector = new Person();
            Console.WriteLine("Chest contains {0} coins", chest.Coins);

            //First Sailor gets all the coins and counts them
            sailor1.TakeCoins(chest, chest.Coins);
            if(!OneIsLeftWhenAmountDividedBy3(sailor1.Coins)) return FailedCondition(sailor1.Coins);
            //sailor throws away one coin and returns 2/3 of the rest of the coins
            sailor1.ThrowCoins(1);
            sailor1.PutCoins(chest, 2 * sailor1.Coins / 3);
            Console.WriteLine("Sailor 1 throws away 1 coin keeps {0} coins. {1} coins back in the chest", sailor1.Coins, chest.Coins);

            //Second Sailor gets all the coins and counts them
            sailor2.TakeCoins(chest, chest.Coins);
            if (!OneIsLeftWhenAmountDividedBy3(sailor2.Coins)) return FailedCondition(sailor2.Coins);
            //sailor throws away one coin and returns 2/3 of the rest of the coins
            sailor2.ThrowCoins(1);
            sailor2.PutCoins(chest, 2 * sailor2.Coins / 3);
            Console.WriteLine("Sailor 2 throws away 1 coin keeps {0} coins. {1} coins back in the chest", sailor2.Coins, chest.Coins);

            //Third Sailor gets all the coins and counts them
            sailor3.TakeCoins(chest, chest.Coins);
            if (!OneIsLeftWhenAmountDividedBy3(sailor3.Coins)) return FailedCondition(sailor3.Coins);
            //sailor throws away one coin and returns 2/3 of the rest of the coins
            sailor3.ThrowCoins(1);
            sailor3.PutCoins(chest, 2 * sailor3.Coins / 3);
            Console.WriteLine("Sailor 3 throws away 1 coin keeps {0} coins. {1} coins back in the chest", sailor3.Coins, chest.Coins);

            //Tax collector takes all the coins and counts them
            taxCollector.TakeCoins(chest, chest.Coins);
            if (!OneIsLeftWhenAmountDividedBy3(taxCollector.Coins)) return FailedCondition(taxCollector.Coins);
            Console.WriteLine("Tax collector gives {0} coins to each sailor and keeps 1 for himself.", (taxCollector.Coins - 1) / 3, chest.Coins);
            //tax collector gives one third of the coins to each sailar and keeps the extra one
            int oneThirdOfTheCoins = (taxCollector.Coins - 1) / 3;
            taxCollector.GiveCoins(sailor1, oneThirdOfTheCoins);
            taxCollector.GiveCoins(sailor2, oneThirdOfTheCoins);
            taxCollector.GiveCoins(sailor3, oneThirdOfTheCoins);
            Console.WriteLine("Final State");
            Console.WriteLine("Chest: {0}   Sailor 1: {1}   Sailor 2: {2}   Sailor 3: {3}   Collector: {4}  Sea: 3", chest.Coins, sailor1.Coins, sailor2.Coins, sailor3.Coins, taxCollector.Coins);

            if (!taxCollector.Coins.Equals(1)) return false;
            Console.WriteLine("We found it!!");
            return true;
        }
        private bool OneIsLeftWhenAmountDividedBy3(int amount)
        {
            return (amount % 3).Equals(1);
        }
        private bool FailedCondition(int amount)
        {
            Console.WriteLine("{0} when divided by 3 does not have a remainder of 1. This story is not the one!", amount);
            Console.WriteLine("  ");
            return false;
        }
    }
}

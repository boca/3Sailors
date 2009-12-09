using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3Sailors
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 200; i <= 300; i++)
                if (new Story(i).AmountWorks())
                    break;
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Whiles.Homework.ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxnum = 0;
            for (int i = n; i > 0; i--)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 1)
                {
                    if (x > maxnum)
                    {
                        maxnum = x;
                    }
                }

            }
            Console.WriteLine(maxnum % 10 + maxnum / 10);
            Console.ReadLine();
        }
    }
}

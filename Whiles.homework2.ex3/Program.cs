using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiles.homework2.ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minnum = int.MaxValue;
            for (int i = n; i > 0; i--)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < minnum)
                {
                    minnum = x;
                }

            }
            Console.WriteLine(minnum);
            Console.ReadLine();
        }
    }
}

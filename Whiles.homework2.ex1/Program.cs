
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Whiles.homework2.ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxnum = 0;
            for (int i = n; i > 0; i--)
            {
                int num = int.Parse(Console.ReadLine());
                if (num %2 == 0)
                {
                    if (num > maxnum)
                    {
                        maxnum = num;
                    }
                }
            }
            Console.WriteLine(maxnum);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiles.homework.ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minnum = int.MaxValue;
            int counter = 0;
            for (int i = n; i > 0; i--)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 100 && x<minnum)
                {
                    minnum = x; 
                    counter += 1;
                }
            }
            if (counter >= 1)
            {
                Console.WriteLine(minnum);
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
            
        }
    }
}

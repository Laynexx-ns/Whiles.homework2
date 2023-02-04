using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiles.homework2.ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Пользователь вводит число n, затем n раз вводит числа. 
            Найдите среди чисел минимальное число кратное 5 и выведите его на экран.
            Если такого числа нет, то выведите фразу NO*/
            int n = int.Parse(Console.ReadLine());
            int minnum = int.MaxValue;
            int count = 0;
            for (int i = n; i > 0; i--)
            {
                int x = int.Parse(Console.ReadLine());
                if (x%5 == 0)
                {
                    if (x < minnum)
                    {
                        minnum = x;
                        count += 1;
                    }
                }
            }
            if (count > 0)
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

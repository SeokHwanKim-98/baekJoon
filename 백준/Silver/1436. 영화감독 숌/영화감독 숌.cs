using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0118_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int count = 0;
            int num = 666;

            while (true)
            {
                if (Contains666(num))
                {
                    count++;
                }
                
                if (count == N)
                {
                    Console.WriteLine($"{num}");
                    break;
                }
                num++;
            }
        }

        static bool Contains666(int n)
        {
            string strNum = n.ToString();
            return strNum.Contains("666");
        }
    }
}

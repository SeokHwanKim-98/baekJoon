using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int zeroCount = 0;

            while(n >= 5)
            {
                zeroCount += n / 5;
                n /= 5;
            }
            Console.WriteLine(zeroCount);
        }
    }
}

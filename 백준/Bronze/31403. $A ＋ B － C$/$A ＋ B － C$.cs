using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1225_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            string C = Console.ReadLine();

            int a = int.Parse(A);
            int b = int.Parse(B);
            int c = int.Parse(C);


            Console.WriteLine(a + b - c);
            Console.WriteLine(int.Parse(A+B)-c);
        }

    }
}

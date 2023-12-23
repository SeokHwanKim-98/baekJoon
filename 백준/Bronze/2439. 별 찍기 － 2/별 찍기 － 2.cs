using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_23._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputSize = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputSize; i++)
            {
                string empty = new string(' ', inputSize - i);
                string str = new string('*', i);
                Console.WriteLine(empty + str);
            }
        }
    }
}
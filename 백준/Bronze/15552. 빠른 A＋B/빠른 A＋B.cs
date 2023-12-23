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
            StringBuilder sb = new StringBuilder();

            int inputSize = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < inputSize; i++)
            {
                string[] num = Console.ReadLine().Split();
                sb.Append(int.Parse(num[0]) + int.Parse(num[1]) + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
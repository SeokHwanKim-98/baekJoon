using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0122_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] num = Console.ReadLine().Split();
            int [] inputN = new int[num.Length];
            int [] sortN = new int[num.Length];
            int [] reverseN = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                inputN[i] = int.Parse(num[i]);
                sortN[i] = int.Parse(num[i]);
                reverseN[i] = int.Parse(num[i]);
            }
            Array.Sort(sortN);
            Array.Sort(reverseN);
            Array.Reverse(reverseN);

            if (Enumerable.SequenceEqual(inputN, sortN)) { Console.WriteLine("ascending"); }
            else if (Enumerable.SequenceEqual(inputN, reverseN)) { Console.WriteLine("descending"); }
            else { Console.WriteLine("mixed"); }
        }
    }
}

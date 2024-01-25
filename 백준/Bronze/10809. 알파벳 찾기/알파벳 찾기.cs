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
            string S = Console.ReadLine();
            int[] intAlpha = new int[26];
            for (char j = 'a'; j <= 'z'; j++)
            {
                intAlpha[j - 'a'] = S.IndexOf(j);
            }
            for (int i = 0; i < intAlpha.Length; i++) { Console.Write(intAlpha[i] + " "); }
        }
    }
}

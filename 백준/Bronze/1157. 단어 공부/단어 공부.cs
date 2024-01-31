using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace _0131_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string upperS = S.ToUpper();
            int[] intAlpha = new int[26];
            int freq = 0;
            int manyQ = 0;
            char many = 'A';
            for (char j = 'A'; j <= 'Z'; j++)
            {
                freq = upperS.Count(f => (f == j));
                if (manyQ < freq) { manyQ = freq; many = j; }
                else if (manyQ == freq ) { many = '?'; }
            }

            Console.WriteLine(many);
        }
    }
}

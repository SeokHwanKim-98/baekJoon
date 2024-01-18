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
            while ( true )
            {
                string num = Console.ReadLine();
                if ( num == "0") { break; }
                char [] input = num.ToCharArray();
                char [] chars = num.ToCharArray();
                Array.Reverse( chars );
                if (Enumerable.SequenceEqual(chars,input)) { Console.WriteLine("yes"); }
                else { Console.WriteLine("no"); }
            }
        }
    }
}

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
            int T = int.Parse(Console.ReadLine());

            int height;
            int room;
            string result;
            for (int i = 1; i <= T; i++)
            {
                string[] HWN = Console.ReadLine().Split();
                int H = int.Parse(HWN[0]); // height
                int W = int.Parse(HWN[1]); // room
                int N = int.Parse(HWN[2]); // guest

                if ( N % H == 0 )
                {
                    height = H;
                    room = N / H;
                }
                else { height = N % H; room = N / H + 1; }
                
                result = height.ToString() + room.ToString("00");

                Console.WriteLine(result);
            }
        }
    }
}

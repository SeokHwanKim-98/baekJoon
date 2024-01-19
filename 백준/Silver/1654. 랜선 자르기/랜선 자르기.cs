using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0119_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] KN = Console.ReadLine().Split();
            int K = int.Parse(KN[0]);
            int N = int.Parse(KN[1]);

            long[] lanCables = new long[K];
            for (int i = 0; i < K; i++)
            {
                lanCables[i] = long.Parse(Console.ReadLine());
            }

            Array.Sort(lanCables);
            long result = BinarySearch(lanCables, N);

            Console.WriteLine(result);
        }

        static int BinarySearch(long [] lanCables, int j)
        {
            long result = 0;
            long low = 1;
            long high = lanCables[lanCables.Length - 1];
            
            while(low <= high)
            {
                long mid = (low + high) / 2;
                int count = 0;
                foreach(long cable in lanCables)
                {
                    count += (int)(cable / mid);
                }
                if (count >= j)
                {
                    low = mid + 1;
                    result = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return (int)result;
        }
    }
}

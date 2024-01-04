using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0104_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 바구니의 개수 N과 교환 횟수 M을 입력 받음
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            // 초기 바구니 상태 배열
            int[] baskets = new int[N];
            for (int i = 0; i < N; i++)
            {
                baskets[i] = i + 1;
            }

            // 교환 횟수만큼 반복
            for (int m = 0; m < M; m++)
            {
                // 교환할 바구니의 번호를 입력 받음
                input = Console.ReadLine().Split();
                int i = int.Parse(input[0]) - 1; // 0-based index로 변환
                int j = int.Parse(input[1]) - 1; // 0-based index로 변환

                // 바구니 교환
                int temp = baskets[i];
                baskets[i] = baskets[j];
                baskets[j] = temp;
            }

            // 최종 바구니 상태 출력
            Console.WriteLine(string.Join(" ", baskets));
        }
    }
}

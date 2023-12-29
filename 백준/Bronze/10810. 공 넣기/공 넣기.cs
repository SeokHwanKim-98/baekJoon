namespace _1229_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]); // 바구니의 개수
            int M = int.Parse(input[1]); // 공을 넣는 횟수

            int[] baskets = new int[N + 1]; // 바구니의 상태를 저장하는 배열

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split();
                int start = int.Parse(input[0]); // 시작 바구니
                int end = int.Parse(input[1]); // 끝 바구니
                int ballNumber = int.Parse(input[2]); // 넣을 공의 번호

                // 주어진 범위의 바구니에 공을 넣거나 갱신
                for (int j = start; j <= end; j++)
                {
                    baskets[j] = ballNumber;
                }
            }

            // 결과 출력
            for (int i = 1; i <= N; i++)
            {
                Console.Write(baskets[i] + " ");
            }
        }
    }
}
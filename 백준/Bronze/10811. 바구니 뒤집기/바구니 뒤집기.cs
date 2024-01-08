namespace _0108_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 첫째 줄에서 N과 M을 입력 받기
            string[] inputNM = Console.ReadLine().Split();
            int N = int.Parse(inputNM[0]);
            int M = int.Parse(inputNM[1]);

            // 바구니의 순서를 저장할 배열 초기화
            int[] baskets = new int[N];
            for (int i = 0; i < N; i++)
            {
                baskets[i] = i + 1;
            }

            // M번 순서를 역순으로 만들기
            for (int m = 0; m < M; m++)
            {
                // 역순으로 만들 범위를 입력 받기
                string[] inputRange = Console.ReadLine().Split();
                int i = int.Parse(inputRange[0]) - 1;  // 배열 인덱스는 0부터 시작하므로 1을 빼줌
                int j = int.Parse(inputRange[1]) - 1;

                // i부터 j까지의 바구니 순서를 역순으로 만들기
                ReverseBaskets(baskets, i, j);
            }

            // 결과 출력
            for (int i = 0; i < N; i++)
            {
                Console.Write(baskets[i] + " ");
            }
        }

        // 배열의 일부를 역순으로 만드는 함수
        static void ReverseBaskets(int[] arr, int start, int end)
        {
            while (start < end)
            {
                // 시작과 끝을 서로 교환
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                // 시작 인덱스 증가, 끝 인덱스 감소
                start++;
                end--;
            }
        }
    }
}

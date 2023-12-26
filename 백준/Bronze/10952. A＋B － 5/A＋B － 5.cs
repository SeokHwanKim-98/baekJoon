namespace _1226_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // 한 줄에 A와 B를 공백을 기준으로 입력 받음
                string[] input = Console.ReadLine().Split();

                // 입력된 값이 "0 0"이면 프로그램 종료
                if (input[0] == "0" && input[1] == "0")
                    break;

                // 입력된 문자열을 정수로 변환
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);

                // A와 B를 더한 값을 출력
                Console.WriteLine(A + B);
            }
        }
    }
}
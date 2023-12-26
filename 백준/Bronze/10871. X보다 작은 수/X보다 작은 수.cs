namespace _1226_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 입력 받은 문자열을 공백을 기준으로 나누어 문자열 배열로 만듦
            string[] stringValues = Console.ReadLine().Split();

            // 문자열 배열을 정수 배열로 변환
            int[] countAndValue = Array.ConvertAll(stringValues, int.Parse);

            // countAndValue 배열을 사용하여 작업 수행
            // 예: countAndValue[0]은 개수, countAndValue[1]은 기준값
            int count = countAndValue[0];
            int value = countAndValue[1]; 
            
            // arrayA배열에 입력값 받고 ' '로 분리해서 저장
            string [] arrayA = Console.ReadLine().Split();

            // 변환을 위해 intA배열을 만들고 for문으로 int로 변환한 뒤 value보다 작으면 출력
            int [] intA = new int[arrayA.Length];
            for(int i = 0; i < count; i++)
            {
                intA[i] = int.Parse(arrayA[i]);
                if (intA[i] < value)  {  Console.Write(intA[i] + " "); }
            }
        }
    }
}
namespace _0110_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine(); //문자열 입력받음
            int num = int.Parse(Console.ReadLine()); //번호 입력받음
            char result = 'N'; // 변수만들고 초기화
            if (num >= 1 && num <= str.Length) // 입력받은 번호가 1보다 크거나 같고, 입력받은 문자열 길이보다 작거나 같을때
            {
                result = str[num - 1]; // 입력받은 문자열 중 입력받은 번호보다 1작은 위치에 있음.
            }
            Console.WriteLine(result);
        }
    }
}
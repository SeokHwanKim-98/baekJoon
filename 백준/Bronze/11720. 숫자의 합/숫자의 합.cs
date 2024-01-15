namespace _0115_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countN = int.Parse(Console.ReadLine());
            string inputNum = Console.ReadLine();
            char[] inputN = inputNum.ToCharArray();
            int result = 0;
            for (int i = 0; i < countN; i++)
            {
                result += inputN[i] - '0';
            }
            Console.WriteLine(result);
        }
    }
}
namespace Test4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            string [] arrayNum = inputNum.Split();
            long result = 0;
            long[] plusNum = new long[arrayNum.Length];
            for(int i = 0; i < arrayNum.Length; i++)
            {
                plusNum[i] = long.Parse(arrayNum[i]);
                result += plusNum[i];
            }
            Console.WriteLine(result);
        }
    }
}
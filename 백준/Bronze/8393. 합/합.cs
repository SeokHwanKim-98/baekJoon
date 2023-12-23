namespace _12_23._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i < inputNum+1; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }
    }
}
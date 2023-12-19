namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string[] sNum = num.Split();
            int a = int.Parse(sNum[0]);
            int b = int.Parse(sNum[1]);
            Console.WriteLine(a * b);
        }
    }
}
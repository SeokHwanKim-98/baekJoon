namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string[] sNum = num.Split();
            double a = int.Parse(sNum[0]);
            double b = int.Parse(sNum[1]);
            Console.WriteLine(a / b);
        }
    }
}
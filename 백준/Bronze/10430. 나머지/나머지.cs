namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            string [] arrayNum = inputNum.Split();
            int A = int.Parse(arrayNum[0]);
            int B = int.Parse(arrayNum[1]);
            int C = int.Parse(arrayNum[2]);
            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}
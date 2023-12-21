namespace test5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputScore = int.Parse(Console.ReadLine());

            if (inputScore >= 90) { Console.WriteLine("A"); }
            else if (inputScore >= 80) { Console.WriteLine("B"); }
            else if (inputScore >= 70) { Console.WriteLine("C"); }
            else if (inputScore >= 60) { Console.WriteLine("D"); }
            else { Console.WriteLine("F"); }
        }
    }
}
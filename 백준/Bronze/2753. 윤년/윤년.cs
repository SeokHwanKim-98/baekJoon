namespace test5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputYear = int.Parse(Console.ReadLine());

            if (inputYear % 4 == 0 && (inputYear % 100 != 0 || inputYear % 400 == 0)) {
                Console.WriteLine("1");
            }
            else { Console.WriteLine("0"); }
        }
    }
}
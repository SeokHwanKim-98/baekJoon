namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNum1 = Console.ReadLine();
            string inputNum2 = Console.ReadLine();
            string multipleNumOne = inputNum2.Substring(2, 1);
            string multipleNumTen = inputNum2.Substring(1, 1);
            string multipleNumHund = inputNum2.Substring(0, 1);
            int multiNum1 = int.Parse(inputNum1);
            int multiNumOne = int.Parse(multipleNumOne);
            int multiNumTen = int.Parse(multipleNumTen);
            int multiNumHund = int.Parse(multipleNumHund);
            int multiNum2 = int.Parse(inputNum2);
            Console.WriteLine(multiNum1 * multiNumOne);
            Console.WriteLine(multiNum1 * multiNumTen);
            Console.WriteLine(multiNum1 * multiNumHund);
            Console.WriteLine(multiNum1 * multiNum2);
        }
    }
}
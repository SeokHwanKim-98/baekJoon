namespace _12_23._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputFinResult = int.Parse(Console.ReadLine());
            int inputCountResult = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < inputCountResult; i++)
            {
                string inputPrize = Console.ReadLine();
                string[] priceAndCount = inputPrize.Split();
                int[] price = new int[inputCountResult];
                int[] count = new int[inputCountResult];
                price[i] = int.Parse(priceAndCount[0]);
                count[i] = int.Parse(priceAndCount[1]);
                result += (price[i] * count[i]);
            }
            if (result == inputFinResult) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }
    }
}
namespace _1227_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            string [] arrayNum = Console.ReadLine().Split();
            List<int> intList = new List<int>();

            for (int i=0; i<inputN; i++)
            {
                intList.Add(int.Parse(arrayNum[i]));
            }
            int maxNum = intList.Max();
            int minNum = intList.Min();
            Console.Write(minNum + " " + maxNum);
        }
    }
}
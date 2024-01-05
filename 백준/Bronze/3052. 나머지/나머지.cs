namespace _0105_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[10];
            for (int i = 0; i < inputArray.Length; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                int nNum = inputNum % 42;
                inputArray[i] = nNum;
            }
            int [] distArray = inputArray.Distinct().ToArray();
            Console.WriteLine(distArray.Length);
        }
    }
}
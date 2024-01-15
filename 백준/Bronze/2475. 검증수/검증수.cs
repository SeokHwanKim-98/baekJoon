namespace _0115_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] inputN = Console.ReadLine().Split();
            int [] num = new int[inputN.Length];
            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(inputN[i]);
                result += num[i]*num[i];
            }
            Console.WriteLine(result%10);
        }
    }
}
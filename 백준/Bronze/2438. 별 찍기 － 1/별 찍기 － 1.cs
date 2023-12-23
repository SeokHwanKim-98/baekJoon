namespace _12_23._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputSize = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputSize; i++)
            {
                string str = new string('*', i);
                Console.WriteLine(str);
            }
        }
    }
}
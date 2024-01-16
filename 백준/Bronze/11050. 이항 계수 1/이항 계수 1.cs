namespace _0116_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] NK = Console.ReadLine().Split(' ');
            int N = int.Parse(NK[0]);
            int K = int.Parse(NK[1]);

            int a = 1, b = 1;
            for (int i = 0; i< K; i++) 
            { 
                a *= N - i; 
                b *= K - i;
            }
            Console.WriteLine(a / b);
        }
    }
}
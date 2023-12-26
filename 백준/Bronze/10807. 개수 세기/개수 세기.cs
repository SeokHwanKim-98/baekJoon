namespace _1226_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            string[] v = Console.ReadLine().Split();
            int [] intV = new int[v.Length];
            int find = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < value; i++)
            {
                intV[i] = int.Parse(v[i]);

                if (intV[i] == find) { count++; }
            }
            Console.WriteLine(count);
        }
    }
}
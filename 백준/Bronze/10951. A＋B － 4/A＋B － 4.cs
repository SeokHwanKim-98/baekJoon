namespace _1226_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == null) { break; }

                string[] input = line.Split();
                
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);

                Console.WriteLine(A + B);
            }
        }
    }
}
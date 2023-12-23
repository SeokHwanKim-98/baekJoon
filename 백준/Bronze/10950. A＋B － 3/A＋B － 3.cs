namespace _12_23._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLine = int.Parse(Console.ReadLine());
            int [] a = new int[inputLine];
            int [] b = new int[inputLine];
            for (int i = 0; i < inputLine; i++)
            {
                string inputAB = Console.ReadLine();
                string[] arrayAB = inputAB.Split();
                a[i] = int.Parse(arrayAB[0]);
                b[i] = int.Parse(arrayAB[1]);
            }
            for (int i=0; i < inputLine; i++) { Console.WriteLine(a[i]+b[i]); }
        }
    }
}
namespace _12_23._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLong = int.Parse(Console.ReadLine());
            int time = inputLong / 4;
            for(int i =0; i< time; i++)
            {
                Console.Write("long ");
            }
            Console.WriteLine("int");
        }
    }
}
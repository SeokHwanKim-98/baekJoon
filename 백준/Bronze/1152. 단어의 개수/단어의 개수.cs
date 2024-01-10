namespace _0110_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            if (string.IsNullOrEmpty(inputString) || inputString == " ")
            {
                Console.WriteLine("0");
                Environment.Exit(0);
            }
            if (inputString != null && inputString.Length <= 10000000)
            {
                string [] arrayString = inputString.Trim().Split();
                Console.WriteLine(arrayString.Length);
            }
        }
    }
}
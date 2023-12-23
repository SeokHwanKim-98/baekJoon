namespace _12_23._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputMult = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++) { Console.WriteLine(inputMult+ " * " + i + " = " + (inputMult*i) ); }
        }
    }
}
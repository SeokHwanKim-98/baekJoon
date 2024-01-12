namespace _0112_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputA = int.Parse(Console.ReadLine());
            int inputB = int.Parse(Console.ReadLine());
            int inputC = int.Parse(Console.ReadLine());

            int[] result = new int[10];
            int mul = inputA * inputB * inputC;
            
            while ( mul > 0)
            {
                int digit = mul % 10;
                result[digit]++;
                mul /= 10;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
namespace _0105_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
            for(int i = 0; i < 28; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                numArray = numArray.Where(num => num != inputNum).ToArray();
            }
            Console.WriteLine(numArray[0]);
            Console.WriteLine(numArray[1]);
        }
    }
}
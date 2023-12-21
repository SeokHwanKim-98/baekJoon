namespace test5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            string [] arrayNum = inputNum.Split();
            int [] calNumArray = new int[2];
            for (int i = 0; i < arrayNum.Length; i++) { calNumArray[i] = int.Parse(arrayNum[i]); }
            if (calNumArray[0] > calNumArray[1]) { Console.WriteLine(">"); }
            else if (calNumArray[0] < calNumArray[1]) { Console.WriteLine("<"); }
            else if (calNumArray[0] == calNumArray[1]) { Console.WriteLine("=="); }
        }
    }
}
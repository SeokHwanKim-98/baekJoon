namespace _1227_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int biggestNum = 0;
            List<int> intList = new List<int>(); // list 초기화

            for (int i=0; i<9; i++)
            {
                int inputN = int.Parse(Console.ReadLine()); // 값 입력받고 int로 변환

                intList.Add(inputN);
                if (intList.Max() > biggestNum)
                {
                    biggestNum = intList.Max();
                    num = i + 1;
                }
            }
            Console.WriteLine(biggestNum);
            Console.WriteLine(num);
        }
    }
}
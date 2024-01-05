namespace _0105_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string [] inputScore = Console.ReadLine().Split();
            double [] scoreArray = new double[count];
            double maxScore = 0;

            for (int i = 0; i < count; i++)
            {
                scoreArray[i] = int.Parse(inputScore[i]);
                if (scoreArray[i] >= maxScore) { maxScore = scoreArray[i]; }
            }
            //foreach ( int num in scoreArray) { Console.WriteLine(num + " "); }
            //Console.WriteLine("MaxScore : " + maxScore);
            double result = 0;
            for (int i=0; i<count; i++)
            {
                result = scoreArray[i] / maxScore * 100 + result;
                //Console.WriteLine("scoreArray[" + i+ "] : " + scoreArray[i] + " maxScore : " + maxScore + " result : " + result);
            }
            Console.WriteLine(result / count);
        }
    }
}
namespace _12_23._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputTime = Console.ReadLine();
            string[] arrayTime = inputTime.Split();
            int hour = int.Parse(arrayTime[0]);
            int minute = int.Parse(arrayTime[1]);
            if ( minute - 45 < 0 )
            {
                if ( hour - 1 < 0) { hour = 23; }
                else { hour--; }
                minute = 60 + (minute - 45);
                Console.WriteLine(hour + " " + minute);
            }
            else if ( minute - 45 >= 0 )
            {
                Console.WriteLine(hour + " " + (minute - 45));
            }
        }
    }
}
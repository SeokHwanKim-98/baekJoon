namespace _12_23._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input Program
            string inputTime = Console.ReadLine();
            string[] arrayTime = inputTime.Split();
            int hour = int.Parse(arrayTime[0]);
            int minute = int.Parse(arrayTime[1]);
            int inputCookTime = int.Parse(Console.ReadLine());
            // input Minute make H M
            int cookTimeHour = inputCookTime / 60;
            int cookTimeMinute = inputCookTime % 60;
            if(minute + cookTimeMinute >= 60)
            {
                hour++;
                minute = 60 - minute - cookTimeMinute;
                if (minute < 0 ) { minute = -minute; }
            }
            else { minute = minute + cookTimeMinute; }
            if (hour + cookTimeHour == 24 ) { hour = 0; }
            else if (hour + cookTimeHour > 24) { hour = hour+cookTimeHour-24; }
            else { hour = hour+ cookTimeHour; }
            Console.WriteLine(hour + " " + minute);
        }
    }
}
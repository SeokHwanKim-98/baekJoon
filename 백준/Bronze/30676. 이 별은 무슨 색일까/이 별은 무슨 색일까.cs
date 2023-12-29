namespace _1229_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input >= 380 && input < 425) { Console.WriteLine("Violet"); }
            else if (input >= 425 && input < 450) { Console.WriteLine("Indigo"); }
            else if (input >= 450 && input < 495) { Console.WriteLine("Blue"); }
            else if (input >= 495 && input < 570) { Console.WriteLine("Green"); }
            else if (input >= 570 && input < 590) { Console.WriteLine("Yellow"); }
            else if (input >= 590 && input < 620) { Console.WriteLine("Orange"); }
            else if (input >= 620 && input <= 780) { Console.WriteLine("Red"); }
        }
    }
}
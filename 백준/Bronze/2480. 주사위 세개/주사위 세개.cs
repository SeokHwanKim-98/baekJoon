namespace _12_23._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputDice = Console.ReadLine();
            string[] arrayDice = inputDice.Split();
            int[] dice = new int[arrayDice.Length];
            int price = 0;
            for(int i =0; i< arrayDice.Length; i++)
            {
                dice[i] = int.Parse(arrayDice[i]);
            }
            if (dice[0] == dice[1] && dice[0] == dice[2] ) { price = 10000 + (dice[0] * 1000); }
            else if(dice[0] == dice[1] || dice[0] == dice[2]) { price = 1000 + (dice[0] * 100); }
            else if(dice[1] == dice[2]) { price = 1000 + (dice[1] * 100); }
            else {
                if (dice[0] > dice[1] && dice[0] > dice[2] ) { price = dice[0] * 100; }
                else if (dice[1] > dice[0] && dice[1] > dice[2] ) { price = dice[1] * 100; }
                else { price = dice[2] * 100; }
            }
            Console.WriteLine(price);
        }
    }
}
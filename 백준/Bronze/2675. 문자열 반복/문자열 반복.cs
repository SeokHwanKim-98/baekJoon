namespace _0115_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            List<string> inputList = new List<string>();

            for (int i = 0; i< time; i++)
            {
                inputList.Add(Console.ReadLine());
            }
            
            foreach(string input in inputList)
            {
                string[] S = input.Split();
                int R = int.Parse(S[0]);
                char [] cS = S[1].ToCharArray();
                string result = "";
                for (int j = 0; j < cS.Length; j++)
                {
                    result += new string(cS[j], R);
                }
                Console.WriteLine(result);
            }
        }
    }
}
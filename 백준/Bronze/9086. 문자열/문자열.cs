namespace _0110_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char[] start = new char[num];
            char[] end = new char[num];
            string [] result = new string[num];
            for (int i = 0; i < num; i++)
            {
                string str = Console.ReadLine(); //문자열 입력받음
                start[i] = str[0];
                end[i] = str[str.Length - 1];
                result[i] = start[i].ToString() + end[i].ToString();
            }
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
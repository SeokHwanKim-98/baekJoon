using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < t; i++)
            {
                int totalscore = 0;
                int currentscore = 1;

                string ox = Console.ReadLine();
                char[] charsOX = ox.ToCharArray();

                for (int j =0; j < charsOX.Length; j++)
                {
                    if (charsOX[j] == 'O')
                    { // 지금 계산하는 j가 맞았을때
                        if (j > 0)
                        {
                            if (charsOX[j-1] == 'O') { currentscore++; } // 이전 j도 맞았으면 더해야할 점수 +1
                            else if (charsOX[j - 1] == 'X') { currentscore = 1; } // 이전 j가 틀렸으면 더해야할 점수 = 1
                            totalscore += currentscore;
                        }
                        else if (j == 0)
                        {
                            if (charsOX[0] == 'O') { totalscore++; }
                        }
                    }
                    else { currentscore = 0; }
                }
                Console.WriteLine(totalscore);
            }
        }
    }
}

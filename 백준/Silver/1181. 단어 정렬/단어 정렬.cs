using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0117_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<string> words = new List<string>();

            for (int i = 0; i < N; i++)
            {
                string word = Console.ReadLine();
                if (!words.Contains(word)) // 중복판별(리스트안에 입력받은값이 없으면 리스트에 추가해라)
                {
                    words.Add(word);
                }
            }

            // 조건에 따라 정렬
            words.Sort((x, y) =>
            {
                if (x.Length == y.Length) // 오름차순정렬하던중에 길이가 같은 두 단어를 발견하면
                {
                    return string.Compare(x, y); // string.Compare : 두 값을 사전순서로 비교하는것
                }
                return x.Length.CompareTo(y.Length);
            });

            StringBuilder result = new StringBuilder();

            // 정렬된 결과 출력
            foreach (var word in words)
            {
                result.AppendLine(word);
            }

            Console.WriteLine(result.ToString());
        }
    }
}

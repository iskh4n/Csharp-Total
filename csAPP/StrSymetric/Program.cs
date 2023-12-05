using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrSymetric
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string S = "racecar"; // Test için örnek bir girdi

            Solution solution = new Solution();
            int result = solution.solution(S);

            if (result != -1)
            {
                Console.WriteLine("Index of character with reversed substrings: " + result);
            }
            else
            {
                Console.WriteLine("No such index exists.");
            }

            Console.ReadLine();
        }

        class Solution
        {
            public int solution(string S)
            {
                int length = S.Length;

                for (int i = 0; i < length; i++)
                {
                    string left = S.Substring(0, i);
                    string right = S.Substring(i + 1);

                    if (IsReversed(left, right))
                    {
                        return i;
                    }
                }

                return -1;
            }

            private bool IsReversed(string left, string right)
            {
                char[] leftChars = left.ToCharArray();
                Array.Reverse(leftChars);
                string reversedLeft = new string(leftChars);

                return reversedLeft == right;
            }
        }









    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumber
{
    class Program
    {
        public static int solution(int[] A)
        {
            Dictionary<int, int> sayiDict = new Dictionary<int, int>();

            foreach (int num in A)
            {
                if (sayiDict.ContainsKey(num))
                {
                    sayiDict[num]++;
                }
                else
                {
                    sayiDict[num] = 1;
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (sayiDict[A[i]] == 1)
                {
                    return A[i];
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] A = { 1, 4, 3, 3, 1, 2 };
            int result = solution(A);
            Console.WriteLine(result); // It will print the result
            Console.ReadLine();
        }
    }



}


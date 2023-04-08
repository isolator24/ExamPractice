using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice
{
    sealed internal class TwoSum
    {
        public TwoSum() { 
        }
        
        public void solveTwoSumProblem()
        {
            var num = new int[] { 2, 7, 11, 15 };
            var target = 9;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[j] == target - num[i])
                    {
                        Console.WriteLine(new int[] { i, j });
                        Console.WriteLine($"index i is {i} with value of {num[i]} \r\nindex j is {j} with value of {num[j]} ");
                    }

                }
            }
        }
    }
}

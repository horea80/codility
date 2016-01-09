using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility.Five.PassingCars
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int N = A.Length;
            int eastBoundCount = 0;
            int passingCount = 0;

            for(int i = 0; i < N; i++)
            {
                if (A[i] == 1)
                {
                    passingCount += eastBoundCount;
                }
                else
                {
                    eastBoundCount++;
                }
                if (passingCount > 1000000000) return -1;
            }
            return passingCount;
        }
    }
}

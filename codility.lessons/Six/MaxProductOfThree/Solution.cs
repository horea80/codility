using System;

namespace codility.Six.MaxProductOfThree
{
    public class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            var n = A.Length;

            var maxOne = A[n - 1]*A[n - 2]*A[n - 3];
            var maxTwo = A[0]*A[1]*A[n - 1];

            return Math.Max(maxOne, maxTwo);
        }
    }
}

namespace codility.Five.MinAvgSlice
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int[] prefixSums = new int[A.Length];
            var sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                prefixSums[i] = sum;
            }

            sum = 0;
            int[] suffixSums = new int[A.Length];
            for (int i = A.Length-1; i >= 0; i--)
            {
                sum += A[i];
                suffixSums[i] = sum;
            }
            return 0;
        }
    }
}

namespace codility.Five.CountDiv
{
    public class Solution
    {
        public int solution(int A, int B, int K)
        {   
            int divisorsGreaterThanA = B / K - A / K;

            return (A % K == 0) ? divisorsGreaterThanA + 1 : divisorsGreaterThanA;
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace codility.Five.GenomicRangeQuery
{
    public class Solution
    {
        private static readonly Dictionary<char, int> GeneImpact = new Dictionary<char, int>()
        {
            {'A', 1},
            {'C', 2},
            {'G', 3},
            {'T', 4},
        };
        
        private static int[][] allCounters;

        public int[] solution(string S, int[] P, int[] Q)
        {
            int N = S.Length;
            int M = P.Length;
            var retVal = new int[M];
                        
            allCounters = new[] {new int[N], new int[N], new int[N], new int[N]};

            DetermineIncrementakCounters(S);

            for (int i = 0; i < M; i++)
            {
                if (allCounters[0][Q[i]] > GetCounter(1, P[i]-1))
                {
                    retVal[i] = 1;
                    continue;
                }
                if(allCounters[1][Q[i]] > GetCounter(2, P[i] - 1))
                {
                    retVal[i] = 2;
                    continue;
                }
                if (allCounters[2][Q[i]] > GetCounter(3, P[i] - 1))
                {
                    retVal[i] = 3;
                    continue;
                }
                if (allCounters[3][Q[i]] > GetCounter(4, P[i] - 1))
                {
                    retVal[i] = 4;
                }
            }

            return retVal.ToArray();
        }

        private static void DetermineIncrementakCounters(string S)
        {
            int N = S.Length;
            var counters = new int[4];

            int impact = 1;
            for (int i = 0; i < N; i++)
            {
                impact = GeneImpact[S[i]];
                counters[impact-1]++;
                allCounters[0][i] = counters[0];
                allCounters[1][i] = counters[1];
                allCounters[2][i] = counters[2];
                allCounters[3][i] = counters[3];
            }
        }
        
        private static int GetCounter(int impact, int index)
        {
            if (index < 0) return 0;
            return allCounters[impact - 1][index];
        }
    }
}
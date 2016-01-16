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
        
        private static int[][] _allCounters;

        public int[] solution(string S, int[] P, int[] Q)
        {
            int n = S.Length;
            int m = P.Length;
            var retVal = new int[m];
                        
            _allCounters = new[] {new int[n], new int[n], new int[n], new int[n]};

            DetermineIncrementakCounters(S);

            for (int i = 0; i < m; i++)
            {
                if (_allCounters[0][Q[i]] > GetCounter(1, P[i]-1))
                {
                    retVal[i] = 1;
                    continue;
                }
                if(_allCounters[1][Q[i]] > GetCounter(2, P[i] - 1))
                {
                    retVal[i] = 2;
                    continue;
                }
                if (_allCounters[2][Q[i]] > GetCounter(3, P[i] - 1))
                {
                    retVal[i] = 3;
                    continue;
                }
                if (_allCounters[3][Q[i]] > GetCounter(4, P[i] - 1))
                {
                    retVal[i] = 4;
                }
            }

            return retVal.ToArray();
        }

        private static void DetermineIncrementakCounters(string s)
        {
            int n = s.Length;
            var counters = new int[4];

            int impact;
            for (int i = 0; i < n; i++)
            {
                impact = GeneImpact[s[i]];
                counters[impact-1]++;
                _allCounters[0][i] = counters[0];
                _allCounters[1][i] = counters[1];
                _allCounters[2][i] = counters[2];
                _allCounters[3][i] = counters[3];
            }
        }
        
        private static int GetCounter(int impact, int index)
        {
            if (index < 0) return 0;
            return _allCounters[impact - 1][index];
        }
    }
}
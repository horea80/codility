using System.Collections.Generic;
using System.Linq;

namespace codility.Six.Distinct
{
    public class Solution
    {
        public int solution(int[] A)
        {
            if (A.Length == 0) return 0;
            if (A.Length == 1) return 1;
            List<int> list = new List<int>(A);
            list.Sort();
            int previousElement = list.First() - 1;
            int distinctCount = 0;
            foreach (var element in list)
            {
                if (element != previousElement)
                {
                    distinctCount++;
                    previousElement = element;
                }
            }

            return distinctCount;
        }
    }
}

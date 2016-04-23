using codility.Six.MaxProductOfThree;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace codility.test.Six.MaxProductOfThree
{
    public class SolutionTests
    {
        [Test]
        public void GivenExerciseSample_ThenSolveIt()
        {
            int[] A = new[] {-3, 1, 2, -2, 5, 6};
            var sol = new Solution();

            Assert.AreEqual(60, sol.solution(A));
        }

        [Test]
        public void GivenAllNegatives()
        {
            int[] A = new[] { -3, -1000, -2, -2, -5, -6 };
            var sol = new Solution();

            Assert.AreEqual(-12, sol.solution(A));
        }

        [Test]
        public void GivenOnePositive()
        {
            int[] A = new[] { -3, -1000, -2, -2, -5, 1 };
            var sol = new Solution();

            Assert.AreEqual(5000, sol.solution(A));
        }
    }
}

using NUnit.Framework;

namespace codility.Five.GenomicRangeQuery.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test]
        public void exampleTest()
        {
            var s = new Solution();
            string genomicRange = "CAGCCTA";
            int[] pQuery = new int[] { 2, 5, 0};
            int[] qQuery = new int[] { 4, 5, 6};

            var queryAnswer = s.solution(genomicRange, pQuery, qQuery);
            Assert.AreEqual(new int[] { 2, 4, 1} , queryAnswer);
        }
        [Test]
        public void extremeDoubleTest()
        {
            var s = new Solution();
            string genomicRange = "AC";
            int[] pQuery = new int[] { 0, 0, 1 };
            int[] qQuery = new int[] { 0, 1, 1 };

            var queryAnswer = s.solution(genomicRange, pQuery, qQuery);
            Assert.AreEqual(new int[] { 1, 1, 2 }, queryAnswer);
        }
    }
}
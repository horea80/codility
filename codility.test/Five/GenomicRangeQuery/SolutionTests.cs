using codility.Five.GenomicRangeQuery;
using NUnit.Framework;

namespace codility.test.Five.GenomicRangeQuery
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test]
        public void ExampleTest()
        {
            var s = new Solution();
            string genomicRange = "CAGCCTA";
            int[] pQuery = new int[] { 2, 5, 0};
            int[] qQuery = new int[] { 4, 5, 6};

            var queryAnswer = s.solution(genomicRange, pQuery, qQuery);
            Assert.AreEqual(new[] { 2, 4, 1} , queryAnswer);
        }
        [Test]
        public void ExtremeDoubleTest()
        {
            var s = new Solution();
            string genomicRange = "AC";
            int[] pQuery = new int[] { 0, 0, 1 };
            int[] qQuery = new int[] { 0, 1, 1 };

            var queryAnswer = s.solution(genomicRange, pQuery, qQuery);
            Assert.AreEqual(new[] { 1, 1, 2 }, queryAnswer);
        }
    }
}
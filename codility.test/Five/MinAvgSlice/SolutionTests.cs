using codility.Five.MinAvgSlice;
using NUnit.Framework;

namespace codility.test.Five.MinAvgSlice
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test]
        public void Example()
        {
            Solution s = new Solution();
            var sliceStart = s.solution(new [] {4, 2, 2, 5, 1, 5, 8});
            Assert.AreEqual(1, sliceStart);
        }
        [Test]
        public void AllNegative()
        {
            Solution s = new Solution();
            var sliceStart = s.solution(new[] { -4, -2, -2, -5, -1, -5, -8 });
            Assert.AreEqual(5, sliceStart);
        }
        [Test]
        public void MixPositiveAndNegative()
        {
            Solution s = new Solution();
            var sliceStart = s.solution(new[] { -4, 2, -2, 5, -1, 5, -8 });
            Assert.AreEqual(2, sliceStart);
        }
        [Test]
        public void MinSliceLargerThanTwo()
        {
            Solution s = new Solution();
            var sliceStart = s.solution(new[] { 4, -2, -3, 1, -6, 5, 8 });
            Assert.AreEqual(2, sliceStart);
        }
    }
}
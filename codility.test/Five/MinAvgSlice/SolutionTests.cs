using codility.Five.MinAvgSlice;
using NUnit.Framework;

namespace codility.test.Five.MinAvgSlice
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test]
        public void ExampleTest()
        {
            Solution s = new Solution();
            var sliceStart = s.solution(new [] {4, 2, 2, 5, 1, 5, 8});
            Assert.AreEqual(1, sliceStart);
        }
    }
}
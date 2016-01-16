using codility.Five.PassingCars;
using NUnit.Framework;

namespace codility.test.Five.PassingCars
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void ExampleTest()
        {
            Solution s = new Solution();
            Assert.AreEqual(5, s.solution(new[] { 0, 1, 0, 1, 1 }));
        }
        [Test()]
        public void GivenAllEast()
        {
            Solution s = new Solution();
            Assert.AreEqual(0, s.solution(new[] { 0, 0, 0, 0, 0 }));
        }
        [Test()]
        public void GivenAllWest()
        {
            Solution s = new Solution();
            Assert.AreEqual(0, s.solution(new[] { 1, 1, 1, 1, 1 }));
        }
    }
}
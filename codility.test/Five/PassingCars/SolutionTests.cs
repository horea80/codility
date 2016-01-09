using NUnit.Framework;
using codility.Five.PassingCars;

namespace codility.Five.PassingCars.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void exampleTest()
        {
            Solution s = new Solution();
            Assert.AreEqual(5, s.solution(new int[] { 0, 1, 0, 1, 1 }));
        }
        [Test()]
        public void givenAllEast()
        {
            Solution s = new Solution();
            Assert.AreEqual(0, s.solution(new int[] { 0, 0, 0, 0, 0 }));
        }
        [Test()]
        public void givenAllWest()
        {
            Solution s = new Solution();
            Assert.AreEqual(0, s.solution(new int[] { 1, 1, 1, 1, 1 }));
        }
    }
}
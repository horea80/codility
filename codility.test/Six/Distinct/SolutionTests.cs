using codility.Six.Distinct;
using NUnit.Framework;

namespace codility.test.Six.Distinct
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void Given_Test_Example()
        {
            Solution s  = new Solution();
            Assert.AreEqual(3, s.solution(new[] {2,1,1,2,3,1}));
        }
        [Test]
        public void Given_Long_Array_When_All_Identical_Then_One()
        {
            Solution s = new Solution();
            Assert.AreEqual(1, s.solution(new[] { 1, 1, 1, 1, 1, 1 }));
        }
        [Test]
        public void Given_Long_Array_When_All_Distinct_Then_Array_Length()
        {
            Solution s = new Solution();
            Assert.AreEqual(6, s.solution(new[] { 1, 2, 3, 4, 5, 6 }));
        }
        [Test]
        public void Given_Array_When_Empty_Then_Zero()
        {
            Solution s = new Solution();
            Assert.AreEqual(0, s.solution(new int[] {}));
        }

        [Test] public void Given_Array_When_Contains_Single_Element_Then_One()
        {
            Solution s = new Solution();
            Assert.AreEqual(1, s.solution(new[] { 1 }));
        }
    }
}
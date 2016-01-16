using codility.Five.CountDiv;
using NUnit.Framework;

namespace codility.test.Five.CountDiv
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void TextBookExample()
        {
            Solution s = new Solution();
            Assert.AreEqual(3, s.solution(6, 11, 2));            
        }
        [Test()]
        public void ExtremeleySmallK()
        {
            Solution s = new Solution();
            Assert.AreEqual(6, s.solution(6, 11, 1));
        }
        [Test()]
        public void ExtremelyLargeK()
        {
            Solution s = new Solution();
            Assert.AreEqual(0, s.solution(6, 11, 2000000000));
        }
        [Test()]
        public void BorderSmallK()
        {
            Solution s = new Solution();
            Assert.AreEqual(5, s.solution(6, 30, 6));
        }
        [Test()]
        public void BorderLargeK()
        {
            Solution s = new Solution();
            Assert.AreEqual(1, s.solution(6, 30, 30));
        }

        [Test()]
        public void SmallInterval()
        {
            Solution s = new Solution();
            Assert.AreEqual(1, s.solution(6, 6, 6));
        }

        [Test()]
        public void EndpointZero()
        {
            Solution s = new Solution();
            Assert.AreEqual(5, s.solution(0, 8, 2));
        }

        [Test()]
        public void AnotherEndpointZero()
        {
            Solution s = new Solution();
            Assert.AreEqual(6, s.solution(0, 30, 6));
        }
    }
}
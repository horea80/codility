using NUnit.Framework;
using codility.Five.CountDiv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility.Five.CountDiv.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void textBookExample()
        {
            Solution s = new Solution();
            Assert.AreEqual(3, s.solution(6, 11, 2));            
        }
        [Test()]
        public void extremeleySmallK()
        {
            Solution s = new Solution();
            Assert.AreEqual(6, s.solution(6, 11, 1));
        }
        [Test()]
        public void extremelyLargeK()
        {
            Solution s = new Solution();
            Assert.AreEqual(0, s.solution(6, 11, 2000000000));
        }
        [Test()]
        public void borderSmallK()
        {
            Solution s = new Solution();
            Assert.AreEqual(5, s.solution(6, 30, 6));
        }
        [Test()]
        public void borderLargeK()
        {
            Solution s = new Solution();
            Assert.AreEqual(1, s.solution(6, 30, 30));
        }

        [Test()]
        public void smallInterval()
        {
            Solution s = new Solution();
            Assert.AreEqual(1, s.solution(6, 6, 6));
        }

        [Test()]
        public void endpointZero()
        {
            Solution s = new Solution();
            Assert.AreEqual(5, s.solution(0, 8, 2));
        }

        [Test()]
        public void anotherEndpointZero()
        {
            Solution s = new Solution();
            Assert.AreEqual(6, s.solution(0, 30, 6));
        }
    }
}
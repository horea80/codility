using NUnit.Framework;
using codility.Four.CountDiv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility.Four.CountDiv.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [Test()]
        public void solutionTest()
        {
            Solution s = new Solution();
            Assert.AreEqual(3, s.solution(6, 11, 2));
            
        }
    }
}
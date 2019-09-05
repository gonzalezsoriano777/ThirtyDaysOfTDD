using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ThirtyDaysOfTDD.UnitTests
{
    [TestFixture]
    public class StringUtilsTest
    {
        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {

            var sentenceToScan = "TDD is awesome!";

            var characterToScanFor = "e";

            var expectedResult = 2;

            var stringUtils = new StringUtils();

            int result = stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);

        }

        public void ShouldBeAbleToCountNumberOfLettersInComplexSentence()
        {

        }
    }
}

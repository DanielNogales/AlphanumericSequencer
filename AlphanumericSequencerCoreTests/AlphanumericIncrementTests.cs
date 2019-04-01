using NUnit.Framework;
using AlphanumericSequencerCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphanumericSequencerCore.Tests
{
    [TestFixture()]
    public class AlphanumericIncrementTests
    {
        [Test()]
        [TestCase("100")]
        public void NumericsValuesTest(string value)
        {
            string resultValue = AlphanumericIncrement.Increment(value, AlphanumericIncrement.Mode.Numeric);
            Assert.AreEqual("101", resultValue);
        }

        [Test()]
        [TestCase("AA")]
        public void AlphanumericsValuesTest(string value)
        {
            string resultValue = AlphanumericIncrement.Increment(value, AlphanumericIncrement.Mode.Alpha);
            Assert.AreEqual("AB", resultValue);
        }
    }
}
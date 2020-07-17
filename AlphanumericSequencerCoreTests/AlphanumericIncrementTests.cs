using NUnit.Framework;
using AlphanumericSequencerCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace AlphanumericSequencerCore.Tests
{
    [TestFixture()]
    public class AlphanumericIncrementTests
    {
        [Test()]
        [TestCase(null, "")]
        [TestCase("000", "001")]
        [TestCase("010", "011")]
        [TestCase("100", "101")]
        [TestCase("205", "206")]
        public void NumericsValuesTest(string value, string expectedValue)
        {
            value = value ?? string.Empty;
            int leghtValue = value.Length;
            string resultValue = AlphanumericIncrement.Increment(value, AlphanumericIncrement.Mode.Numeric);
            resultValue.Should().Be(expectedValue).And.HaveLength(leghtValue);
        }

        [Test()]
        [TestCase(null, "")]
        [TestCase("AA", "AB")]
        [TestCase("AZ", "BA")]
        [TestCase("  ", "  ")]
        [TestCase("ZZ", "AA")]
        public void AlphanumericsValuesTest(string value, string expectedValue)
        {
            value = value ?? string.Empty;
            int leghtValue = value.Length;
            string resultValue = AlphanumericIncrement.Increment(value, AlphanumericIncrement.Mode.Alpha);
            resultValue.Should().Be(expectedValue).And.HaveLength(leghtValue);
        }
    }
}
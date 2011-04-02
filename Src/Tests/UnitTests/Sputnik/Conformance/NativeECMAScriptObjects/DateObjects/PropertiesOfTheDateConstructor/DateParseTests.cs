// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.DateObjects.PropertiesOfTheDateConstructor
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class DateParseTests : SputnikTestFixture
    {
        public DateParseTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.9_Date_Objects\15.9.4_Properties_of_the_Date_Constructor\15.9.4.2_Date.parse")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.4.2")]
        [TestCase("S15.9.4.2_A1_T1.js", Description = "The Date property \"parse\" has { DontEnum } attributes")]
        [TestCase("S15.9.4.2_A1_T2.js", Description = "The Date property \"parse\" has { DontEnum } attributes")]
        [TestCase("S15.9.4.2_A1_T3.js", Description = "The Date property \"parse\" has { DontEnum } attributes")]
        public void TheDatePropertyParseHasDontEnumAttributes(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.4.2")]
        [TestCase("S15.9.4.2_A2_T1.js", Description = "The \"length\" property of the \"parse\" is 1")]
        public void TheLengthPropertyOfTheParseIs1(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.4.2")]
        [TestCase("S15.9.4.2_A3_T1.js", Description = "The Date.parse property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.4.2_A3_T2.js", Description = "The Date.parse property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.4.2_A3_T3.js", Description = "The Date.parse property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        public void TheDateParsePropertyLengthHasReadOnlyDontDeleteDontEnumAttributes(string file)
        {
            RunFile(file);
        }
    }
}
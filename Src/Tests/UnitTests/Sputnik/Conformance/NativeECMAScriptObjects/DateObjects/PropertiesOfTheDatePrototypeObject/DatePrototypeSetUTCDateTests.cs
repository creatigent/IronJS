// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.DateObjects.PropertiesOfTheDatePrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class DatePrototypeSetUTCDateTests : SputnikTestFixture
    {
        public DatePrototypeSetUTCDateTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.9_Date_Objects\15.9.5_Properties_of_the_Date_Prototype_Object\15.9.5.37_Date.prototype.setUTCDate")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.37")]
        [TestCase("S15.9.5.37_A1_T1.js", Description = "The Date.prototype property \"setUTCDate\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.37_A1_T2.js", Description = "The Date.prototype property \"setUTCDate\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.37_A1_T3.js", Description = "The Date.prototype property \"setUTCDate\" has { DontEnum } attributes")]
        public void TheDatePrototypePropertySetUTCDateHasDontEnumAttributes(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.37")]
        [TestCase("S15.9.5.37_A2_T1.js", Description = "The \"length\" property of the \"setUTCDate\" is 1")]
        public void TheLengthPropertyOfTheSetUTCDateIs1(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.37")]
        [TestCase("S15.9.5.37_A3_T1.js", Description = "The Date.prototype.setUTCDate property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.37_A3_T2.js", Description = "The Date.prototype.setUTCDate property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.37_A3_T3.js", Description = "The Date.prototype.setUTCDate property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        public void TheDatePrototypeSetUTCDatePropertyLengthHasReadOnlyDontDeleteDontEnumAttributes(string file)
        {
            RunFile(file);
        }
    }
}
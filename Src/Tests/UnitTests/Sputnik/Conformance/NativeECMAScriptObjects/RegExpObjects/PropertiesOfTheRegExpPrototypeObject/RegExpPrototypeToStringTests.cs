// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects.PropertiesOfTheRegExpPrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class RegExpPrototypeToStringTests : SputnikTestFixture
    {
        public RegExpPrototypeToStringTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.6_Properties_of_the_RegExp_Prototype_Object\15.10.6.4_RegExp.prototype.toString")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.6.4")]
        [TestCase("S15.10.6.4_A10.js", Description = "The RegExp.prototype.toString.length property has the attribute ReadOnly")]
        public void TheRegExpPrototypeToStringLengthPropertyHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.6.4")]
        [TestCase("S15.10.6.4_A11.js", Description = "The length property of the toString method is 1")]
        public void TheLengthPropertyOfTheToStringMethodIs1(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.10.6.4")]
        [TestCase("S15.10.6.4_A6.js", Description = "RegExp.prototype.toString has not prototype property")]
        public void RegExpPrototypeToStringHasNotPrototypeProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.10.6.4")]
        [TestCase("S15.10.6.4_A7.js", Description = "RegExp.prototype.toString can\'t be used as constructor")]
        public void RegExpPrototypeToStringCanTBeUsedAsConstructor(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.6.4")]
        [TestCase("S15.10.6.4_A8.js", Description = "The RegExp.prototype.toString.length property has the attribute DontEnum")]
        public void TheRegExpPrototypeToStringLengthPropertyHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.6.4")]
        [TestCase("S15.10.6.4_A9.js", Description = "The RegExp.prototype.toString.length property has the attribute DontDelete")]
        public void TheRegExpPrototypeToStringLengthPropertyHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }
    }
}
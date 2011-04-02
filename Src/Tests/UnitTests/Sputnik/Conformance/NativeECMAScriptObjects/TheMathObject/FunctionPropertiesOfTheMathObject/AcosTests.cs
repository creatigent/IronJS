// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.FunctionPropertiesOfTheMathObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class AcosTests : SputnikTestFixture
    {
        public AcosTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.2_Function_Properties_of_the_Math_Object\15.8.2.2_acos")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.2")]
        [TestCase("S15.8.2.2_A1.js", Description = "If x is NaN, Math.acos(x) is NaN")]
        public void IfXIsNaNMathAcosXIsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.2")]
        [TestCase("S15.8.2.2_A2.js", Description = "If x is greater than 1, Math.acos(x) is NaN")]
        public void IfXIsGreaterThan1MathAcosXIsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.2")]
        [TestCase("S15.8.2.2_A3.js", Description = "If x is less than -1, Math.acos(x) is NaN")]
        public void IfXIsLessThan1MathAcosXIsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.2")]
        [TestCase("S15.8.2.2_A4.js", Description = "If x is exactly 1, Math.acos(x) is +0")]
        public void IfXIsExactly1MathAcosXIs0(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.8.2.2")]
        [TestCase("S15.8.2.2_A5.js", Description = "Math.acos, recommended that implementations use the approximation algorithms for IEEE 754 arithmetic contained in fdlibm")]
        public void MathAcosRecommendedThatImplementationsUseTheApproximationAlgorithmsForIEEE754ArithmeticContainedInFdlibm(string file)
        {
            RunFile(file);
        }
    }
}
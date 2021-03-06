// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheRegExpConstructorCalledAsAFunctionTests : SputnikTestFixture
    {
        public TheRegExpConstructorCalledAsAFunctionTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.3_The_RegExp_Constructor_Called_as_a_Function")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.3.1")]
        [TestCase("S15.10.3.1_A1_T1.js", Description = "If pattern is an object R whose [[Class]] property is \"RegExp\" and flags is undefined, then return R unchanged")]
        [TestCase("S15.10.3.1_A1_T2.js", Description = "If pattern is an object R whose [[Class]] property is \"RegExp\" and flags is undefined, then return R unchanged")]
        [TestCase("S15.10.3.1_A1_T3.js", Description = "If pattern is an object R whose [[Class]] property is \"RegExp\" and flags is undefined, then return R unchanged")]
        [TestCase("S15.10.3.1_A1_T4.js", Description = "If pattern is an object R whose [[Class]] property is \"RegExp\" and flags is undefined, then return R unchanged")]
        [TestCase("S15.10.3.1_A1_T5.js", Description = "If pattern is an object R whose [[Class]] property is \"RegExp\" and flags is undefined, then return R unchanged")]
        public void IfPatternIsAnObjectRWhoseClassPropertyIsRegExpAndFlagsIsUndefinedThenReturnRUnchanged(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.3.1")]
        [TestCase("S15.10.3.1_A2_T1.js", Description = "If pattern is an object R whose [[Class]] property is \"RegExp\" and flags is defined, then call the RegExp constructor (15.10.4.1), passing it the pattern and flags arguments and return the object constructed by that constructor")]
        [TestCase("S15.10.3.1_A2_T2.js", Description = "If pattern is an object R whose [[Class]] property is \"RegExp\" and flags is defined, then call the RegExp constructor (15.10.4.1), passing it the pattern and flags arguments and return the object constructed by that constructor")]
        public void IfPatternIsAnObjectRWhoseClassPropertyIsRegExpAndFlagsIsDefinedThenCallTheRegExpConstructor151041PassingItThePatternAndFlagsArgumentsAndReturnTheObjectConstructedByThatConstructor(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.3.1")]
        [TestCase("S15.10.3.1_A3_T1.js", Description = "If pattern and flags are defined, then call the RegExp constructor (15.10.4.1), passing it the pattern and flags arguments and return the object constructed by that constructor")]
        [TestCase("S15.10.3.1_A3_T2.js", Description = "If pattern and flags are defined, then call the RegExp constructor (15.10.4.1), passing it the pattern and flags arguments and return the object constructed by that constructor")]
        public void IfPatternAndFlagsAreDefinedThenCallTheRegExpConstructor151041PassingItThePatternAndFlagsArgumentsAndReturnTheObjectConstructedByThatConstructor(string file)
        {
            RunFile(file);
        }
    }
}
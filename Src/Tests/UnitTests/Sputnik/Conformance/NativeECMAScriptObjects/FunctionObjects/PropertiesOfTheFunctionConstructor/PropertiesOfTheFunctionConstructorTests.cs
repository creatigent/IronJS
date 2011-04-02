// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.FunctionObjects.PropertiesOfTheFunctionConstructor
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PropertiesOfTheFunctionConstructorTests : SputnikTestFixture
    {
        public PropertiesOfTheFunctionConstructorTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.3_Function_Objects\15.3.3_Properties_of_the_Function_Constructor")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.3.3")]
        [TestCase("S15.3.3_A1.js", Description = "The Function constructor has the property \"prototype\"")]
        public void TheFunctionConstructorHasThePropertyPrototype(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.3.3")]
        [Category("ECMA 15.3.4")]
        [TestCase("S15.3.3_A2_T1.js", Description = "The value of the internal [[Prototype]] property of the Function constructor is the Function prototype object")]
        [TestCase("S15.3.3_A2_T2.js", Description = "The value of the internal [[Prototype]] property of the Function constructor is the Function prototype object")]
        public void TheValueOfTheInternalPrototypePropertyOfTheFunctionConstructorIsTheFunctionPrototypeObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.3.3")]
        [Category("ECMA 15.3.4")]
        [TestCase("S15.3.3_A3.js", Description = "Function constructor has length property whose value is 1")]
        public void FunctionConstructorHasLengthPropertyWhoseValueIs1(string file)
        {
            RunFile(file);
        }
    }
}
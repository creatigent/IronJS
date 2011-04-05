// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects.PatternSemantics
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class CharacterClassEscapeTests : SputnikTestFixture
    {
        public CharacterClassEscapeTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.2_Pattern_Semantics\15.10.2.12_CharacterClassEscape")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.2.12")]
        [Category("ECMA 7.2")]
        [Category("ECMA 7.3")]
        [TestCase("S15.10.2.12_A1_T1.js", Description = "The production CharacterClassEscape :: s evaluates by returning the set of characters containing the characters that are on the right-hand side of the WhiteSpace (7.2) or LineTerminator (7.3) productions")]
        [TestCase("S15.10.2.12_A1_T2.js", Description = "The production CharacterClassEscape :: s evaluates by returning the set of characters containing the characters that are on the right-hand side of the WhiteSpace (7.2) or LineTerminator (7.3) productions")]
        [TestCase("S15.10.2.12_A1_T3.js", Description = "The production CharacterClassEscape :: s evaluates by returning the set of characters containing the characters that are on the right-hand side of the WhiteSpace (7.2) or LineTerminator (7.3) productions")]
        [TestCase("S15.10.2.12_A1_T4.js", Description = "The production CharacterClassEscape :: s evaluates by returning the set of characters containing the characters that are on the right-hand side of the WhiteSpace (7.2) or LineTerminator (7.3) productions")]
        [TestCase("S15.10.2.12_A1_T5.js", Description = "The production CharacterClassEscape :: s evaluates by returning the set of characters containing the characters that are on the right-hand side of the WhiteSpace (7.2) or LineTerminator (7.3) productions")]
        public void TheProductionCharacterClassEscapeSEvaluatesByReturningTheSetOfCharactersContainingTheCharactersThatAreOnTheRightHandSideOfTheWhiteSpace72OrLineTerminator73Productions(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.2.12")]
        [Category("ECMA 7.2")]
        [Category("ECMA 7.3")]
        [TestCase("S15.10.2.12_A2_T1.js", Description = "The production CharacterClassEscape :: S evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: s")]
        [TestCase("S15.10.2.12_A2_T2.js", Description = "The production CharacterClassEscape :: S evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: s")]
        [TestCase("S15.10.2.12_A2_T3.js", Description = "The production CharacterClassEscape :: S evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: s")]
        [TestCase("S15.10.2.12_A2_T4.js", Description = "The production CharacterClassEscape :: S evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: s")]
        [TestCase("S15.10.2.12_A2_T5.js", Description = "The production CharacterClassEscape :: S evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: s")]
        public void TheProductionCharacterClassEscapeSEvaluatesByReturningTheSetOfAllCharactersNotIncludedInTheSetReturnedByCharacterClassEscapeS(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.2.12")]
        [TestCase("S15.10.2.12_A3_T1.js", Description = "The production CharacterClassEscape :: w evaluates by returning the set of characters containing the sixty-three characters: a - z, A - Z, 0 - 9, _")]
        [TestCase("S15.10.2.12_A3_T2.js", Description = "The production CharacterClassEscape :: w evaluates by returning the set of characters containing the sixty-three characters: a - z, A - Z, 0 - 9, _")]
        [TestCase("S15.10.2.12_A3_T3.js", Description = "The production CharacterClassEscape :: w evaluates by returning the set of characters containing the sixty-three characters: a - z, A - Z, 0 - 9, _")]
        [TestCase("S15.10.2.12_A3_T4.js", Description = "The production CharacterClassEscape :: w evaluates by returning the set of characters containing the sixty-three characters: a - z, A - Z, 0 - 9, _")]
        [TestCase("S15.10.2.12_A3_T5.js", Description = "The production CharacterClassEscape :: w evaluates by returning the set of characters containing the sixty-three characters: a - z, A - Z, 0 - 9, _")]
        public void TheProductionCharacterClassEscapeWEvaluatesByReturningTheSetOfCharactersContainingTheSixtyThreeCharactersAZAZ09_(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.2.12")]
        [TestCase("S15.10.2.12_A4_T1.js", Description = "The production CharacterClassEscape :: W evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: w")]
        [TestCase("S15.10.2.12_A4_T2.js", Description = "The production CharacterClassEscape :: W evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: w")]
        [TestCase("S15.10.2.12_A4_T3.js", Description = "The production CharacterClassEscape :: W evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: w")]
        [TestCase("S15.10.2.12_A4_T4.js", Description = "The production CharacterClassEscape :: W evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: w")]
        [TestCase("S15.10.2.12_A4_T5.js", Description = "The production CharacterClassEscape :: W evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: w")]
        public void TheProductionCharacterClassEscapeWEvaluatesByReturningTheSetOfAllCharactersNotIncludedInTheSetReturnedByCharacterClassEscapeW(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.2.12")]
        [TestCase("S15.10.2.12_A5_T1.js", Description = "The production CharacterClassEscape :: d evaluates by returning the ten-element set of characters containing the characters 0 through 9 inclusive")]
        [TestCase("S15.10.2.12_A5_T2.js", Description = "The production CharacterClassEscape :: d evaluates by returning the ten-element set of characters containing the characters 0 through 9 inclusive")]
        [TestCase("S15.10.2.12_A5_T3.js", Description = "The production CharacterClassEscape :: d evaluates by returning the ten-element set of characters containing the characters 0 through 9 inclusive")]
        [TestCase("S15.10.2.12_A5_T4.js", Description = "The production CharacterClassEscape :: d evaluates by returning the ten-element set of characters containing the characters 0 through 9 inclusive")]
        public void TheProductionCharacterClassEscapeDEvaluatesByReturningTheTenElementSetOfCharactersContainingTheCharacters0Through9Inclusive(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.2.12")]
        [TestCase("S15.10.2.12_A6_T1.js", Description = "The production CharacterClassEscape :: D evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: d")]
        [TestCase("S15.10.2.12_A6_T2.js", Description = "The production CharacterClassEscape :: D evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: d")]
        [TestCase("S15.10.2.12_A6_T3.js", Description = "The production CharacterClassEscape :: D evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: d")]
        [TestCase("S15.10.2.12_A6_T4.js", Description = "The production CharacterClassEscape :: D evaluates by returning the set of all characters not included in the set returned by CharacterClassEscape :: d")]
        public void TheProductionCharacterClassEscapeDEvaluatesByReturningTheSetOfAllCharactersNotIncludedInTheSetReturnedByCharacterClassEscapeD(string file)
        {
            RunFile(file);
        }
    }
}
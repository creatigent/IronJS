// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.StringObjects.PropertiesOfTheStringPrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class StringPrototypeSplitTests : SputnikTestFixture
    {
        public StringPrototypeSplitTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.5_String_Objects\15.5.4_Properties_of_the_String_Prototype_Object\15.5.4.14_String.prototype.split")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.14")]
        [TestCase("S15.5.4.14_A1_T1.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T10.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T11.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T12.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T13.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T14.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T15.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T16.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T17.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T18.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T2.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T3.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T4.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T5.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T6.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T7.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T8.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        [TestCase("S15.5.4.14_A1_T9.js", Description = "String.prototype.split(separator, limit): i) can be transferred to other kinds of objects for use as a method. separator and limit can be any kinds of object since: ii) if separator is not RegExp ToString(separator) performs and iii) ToInteger(limit) performs")]
        public void StringPrototypeSplitSeparatorLimitICanBeTransferredToOtherKindsOfObjectsForUseAsAMethodSeparatorAndLimitCanBeAnyKindsOfObjectSinceIiIfSeparatorIsNotRegExpToStringSeparatorPerformsAndIiiToIntegerLimitPerforms(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.14")]
        [TestCase("S15.5.4.14_A10.js", Description = "The String.prototype.split.length property has the attribute ReadOnly")]
        public void TheStringPrototypeSplitLengthPropertyHasTheAttributeReadOnly(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.14")]
        [TestCase("S15.5.4.14_A11.js", Description = "The length property of the split method is 2")]
        public void TheLengthPropertyOfTheSplitMethodIs2(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.14")]
        [TestCase("S15.5.4.14_A2_T1.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T10.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T11.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T12.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T13.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T14.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T15.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T16.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T17.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T18.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T19.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T2.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T20.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T21.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T22.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T23.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T24.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T25.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T26.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T27.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T28.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T29.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T3.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T30.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T31.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T32.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T33.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T34.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T35.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T36.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T37.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T38.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T39.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T4.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T40.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T41.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T42.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T43.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T5.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T6.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T7.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T8.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        [TestCase("S15.5.4.14_A2_T9.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. The substrings are determined by searching from left to right for occurrences of separator")]
        public void StringPrototypeSplitSeparatorLimitReturnsAnArrayObjectIntoWhichSubstringsOfTheResultOfConvertingThisObjectToAStringHaveBeenStoredTheSubstringsAreDeterminedBySearchingFromLeftToRightForOccurrencesOfSeparator(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.14")]
        [TestCase("S15.5.4.14_A3_T1.js", Description = "String.prototype.split() returns an Array object with:  i) length equaled to 1, ii) [[Get]](0) equaled to the result of converting this object to a string")]
        [TestCase("S15.5.4.14_A3_T10.js", Description = "String.prototype.split() returns an Array object with:  i) length equaled to 1, ii) [[Get]](0) equaled to the result of converting this object to a string")]
        [TestCase("S15.5.4.14_A3_T11.js", Description = "String.prototype.split() returns an Array object with:  i) length equaled to 1, ii) [[Get]](0) equaled to the result of converting this object to a string")]
        [TestCase("S15.5.4.14_A3_T2.js", Description = "String.prototype.split() returns an Array object with:  i) length equaled to 1, ii) [[Get]](0) equaled to the result of converting this object to a string")]
        [TestCase("S15.5.4.14_A3_T3.js", Description = "String.prototype.split() returns an Array object with:  i) length equaled to 1, ii) [[Get]](0) equaled to the result of converting this object to a string")]
        [TestCase("S15.5.4.14_A3_T4.js", Description = "String.prototype.split() returns an Array object with:  i) length equaled to 1, ii) [[Get]](0) equaled to the result of converting this object to a string")]
        [TestCase("S15.5.4.14_A3_T5.js", Description = "String.prototype.split() returns an Array object with:  i) length equaled to 1, ii) [[Get]](0) equaled to the result of converting this object to a string")]
        [TestCase("S15.5.4.14_A3_T6.js", Description = "String.prototype.split() returns an Array object with:  i) length equaled to 1, ii) [[Get]](0) equaled to the result of converting this object to a string")]
        [TestCase("S15.5.4.14_A3_T7.js", Description = "String.prototype.split() returns an Array object with:  i) length equaled to 1, ii) [[Get]](0) equaled to the result of converting this object to a string")]
        [TestCase("S15.5.4.14_A3_T8.js", Description = "String.prototype.split() returns an Array object with:  i) length equaled to 1, ii) [[Get]](0) equaled to the result of converting this object to a string")]
        [TestCase("S15.5.4.14_A3_T9.js", Description = "String.prototype.split() returns an Array object with:  i) length equaled to 1, ii) [[Get]](0) equaled to the result of converting this object to a string")]
        public void StringPrototypeSplitReturnsAnArrayObjectWithILengthEqualedTo1IiGet0EqualedToTheResultOfConvertingThisObjectToAString(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.14")]
        [TestCase("S15.5.4.14_A4_T1.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T10.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T11.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T12.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T13.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T14.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T15.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T16.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T17.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T18.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T19.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T2.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T20.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T21.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T22.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T23.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T24.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T25.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T3.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T4.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T5.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T6.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T7.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T8.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        [TestCase("S15.5.4.14_A4_T9.js", Description = "String.prototype.split (separator, limit) returns an Array object into which substrings of the result of converting this object to a string have been stored. If separator is a regular expression then inside of SplitMatch helper the [[Match]] method of R is called giving it the arguments corresponding")]
        public void StringPrototypeSplitSeparatorLimitReturnsAnArrayObjectIntoWhichSubstringsOfTheResultOfConvertingThisObjectToAStringHaveBeenStoredIfSeparatorIsARegularExpressionThenInsideOfSplitMatchHelperTheMatchMethodOfRIsCalledGivingItTheArgumentsCorresponding(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.5.4.14")]
        [TestCase("S15.5.4.14_A6.js", Description = "String.prototype.split has not prototype property")]
        public void StringPrototypeSplitHasNotPrototypeProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.5.4.14")]
        [TestCase("S15.5.4.14_A7.js", Description = "String.prototype.split can\'t be used as constructor")]
        public void StringPrototypeSplitCanTBeUsedAsConstructor(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.14")]
        [TestCase("S15.5.4.14_A8.js", Description = "The String.prototype.split.length property has the attribute DontEnum")]
        public void TheStringPrototypeSplitLengthPropertyHasTheAttributeDontEnum(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.5.4.14")]
        [TestCase("S15.5.4.14_A9.js", Description = "The String.prototype.split.length property has the attribute DontDelete")]
        public void TheStringPrototypeSplitLengthPropertyHasTheAttributeDontDelete(string file)
        {
            RunFile(file);
        }
    }
}
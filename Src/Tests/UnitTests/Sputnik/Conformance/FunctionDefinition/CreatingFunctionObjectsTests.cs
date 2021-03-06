// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.FunctionDefinition
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class CreatingFunctionObjectsTests : SputnikTestFixture
    {
        public CreatingFunctionObjectsTests()
            : base(@"Conformance\13_Function_Definition\13.2_Creating_Function_Objects")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.1")]
        [TestCase("S13.2.1_A1_T1.js", Description = "The depth of nested function calls reaches 32")]
        public void TheDepthOfNestedFunctionCallsReaches32(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.1")]
        [TestCase("S13.2.1_A4_T1.js", Description = "Objects as arguments are passed by reference")]
        [TestCase("S13.2.1_A4_T2.js", Description = "Objects as arguments are passed by reference")]
        [TestCase("S13.2.1_A4_T3.js", Description = "Objects as arguments are passed by reference")]
        [TestCase("S13.2.1_A4_T4.js", Description = "Objects as arguments are passed by reference")]
        public void ObjectsAsArgumentsArePassedByReference(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.1")]
        [TestCase("S13.2.1_A5_T1.js", Description = "Closures are admitted")]
        [TestCase("S13.2.1_A5_T2.js", Description = "Closures are admitted")]
        public void ClosuresAreAdmitted(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.1")]
        [TestCase("S13.2.1_A6_T1.js", Description = "Primitive types are passed by value")]
        [TestCase("S13.2.1_A6_T2.js", Description = "Primitive types are passed by value")]
        public void PrimitiveTypesArePassedByValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.1")]
        [TestCase("S13.2.1_A7_T1.js", Description = "When the [[Call]] property for a Function object F is called, the following steps are taken: 2. Evaluate F\'s FunctionBody")]
        [TestCase("S13.2.1_A7_T2.js", Description = "When the [[Call]] property for a Function object F is called, the following steps are taken: 2. Evaluate F\'s FunctionBody")]
        [TestCase("S13.2.1_A7_T3.js", Description = "When the [[Call]] property for a Function object F is called, the following steps are taken: 2. Evaluate F\'s FunctionBody")]
        [TestCase("S13.2.1_A7_T4.js", Description = "When the [[Call]] property for a Function object F is called, the following steps are taken: 2. Evaluate F\'s FunctionBody")]
        [TestCase("S13.2.1_A8_T1.js", Description = "When the [[Call]] property for a Function object F is called, the following steps are taken: 2. Evaluate F\'s FunctionBody")]
        [TestCase("S13.2.1_A8_T2.js", Description = "When the [[Call]] property for a Function object F is called, the following steps are taken: 2. Evaluate F\'s FunctionBody")]
        public void WhenTheCallPropertyForAFunctionObjectFIsCalledTheFollowingStepsAreTaken2EvaluateFSFunctionBody(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.1")]
        [TestCase("S13.2.1_A9.1_T1.js", Description = "When the [[Call]] property for a Function object is called, the body is evaluated and if evaluation result has type \"normal\", then \"undefined\" is returned")]
        [TestCase("S13.2.1_A9.1_T2.js", Description = "When the [[Call]] property for a Function object is called, the body is evaluated and if evaluation result has type \"normal\", then \"undefined\" is returned")]
        public void WhenTheCallPropertyForAFunctionObjectIsCalledTheBodyIsEvaluatedAndIfEvaluationResultHasTypeNormalThenUndefinedIsReturned(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.1")]
        [TestCase("S13.2.1_A9_T1.js", Description = "When the [[Call]] property for a Function object is called, the body is evaluated and if evaluation result has type \"return\" its value is not defined, then \"undefined\" is returned")]
        [TestCase("S13.2.1_A9_T2.js", Description = "When the [[Call]] property for a Function object is called, the body is evaluated and if evaluation result has type \"return\" its value is not defined, then \"undefined\" is returned")]
        public void WhenTheCallPropertyForAFunctionObjectIsCalledTheBodyIsEvaluatedAndIfEvaluationResultHasTypeReturnItsValueIsNotDefinedThenUndefinedIsReturned(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A1_T1.js", Description = "Since a function is an object, it might be set to [[Prototype]] property of a new created object through [[Construct]] property")]
        [TestCase("S13.2.2_A1_T2.js", Description = "Since a function is an object, it might be set to [[Prototype]] property of a new created object through [[Construct]] property")]
        public void SinceAFunctionIsAnObjectItMightBeSetToPrototypePropertyOfANewCreatedObjectThroughConstructProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A10.js", Description = "Calling a function as a constructor is possible as long as this.any_Function is declared")]
        public void CallingAFunctionAsAConstructorIsPossibleAsLongAsThisAny_FunctionIsDeclared(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A11.js", Description = "Calling a function as a constructor is possible as long as this.any_Function is declared and called")]
        [TestCase("S13.2.2_A12.js", Description = "Calling a function as a constructor is possible as long as this.any_Function is declared and called")]
        public void CallingAFunctionAsAConstructorIsPossibleAsLongAsThisAny_FunctionIsDeclaredAndCalled(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A13.js", Description = "Calling a function as a constructor is inadmissible as long as this.any_Function is declared by eval and called")]
        [TestCase("S13.2.2_A14.js", Description = "Calling a function as a constructor is inadmissible as long as this.any_Function is declared by eval and called")]
        public void CallingAFunctionAsAConstructorIsInadmissibleAsLongAsThisAny_FunctionIsDeclaredByEvalAndCalled(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A15_T1.js", Description = "When the [[Construct]] property for a Function object F is called, and the object created in the function is returned, the object (declared with \"this\" within a function) will be strong and healthy")]
        [TestCase("S13.2.2_A15_T2.js", Description = "When the [[Construct]] property for a Function object F is called, and the object created in the function is returned, the object (declared with \"this\" within a function) will be strong and healthy")]
        [TestCase("S13.2.2_A15_T3.js", Description = "When the [[Construct]] property for a Function object F is called, and the object created in the function is returned, the object (declared with \"this\" within a function) will be strong and healthy")]
        [TestCase("S13.2.2_A15_T4.js", Description = "When the [[Construct]] property for a Function object F is called, and the object created in the function is returned, the object (declared with \"this\" within a function) will be strong and healthy")]
        public void WhenTheConstructPropertyForAFunctionObjectFIsCalledAndTheObjectCreatedInTheFunctionIsReturnedTheObjectDeclaredWithThisWithinAFunctionWillBeStrongAndHealthy(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A16_T1.js", Description = "FunctionExpression within a new statement is admitted")]
        [TestCase("S13.2.2_A16_T2.js", Description = "FunctionExpression within a new statement is admitted")]
        [TestCase("S13.2.2_A16_T3.js", Description = "FunctionExpression within a new statement is admitted")]
        public void FunctionExpressionWithinANewStatementIsAdmitted(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A17_T1.js", Description = "FunctionExpression containing \"with\" statement is admitted")]
        [TestCase("S13.2.2_A17_T2.js", Description = "FunctionExpression containing \"with\" statement is admitted")]
        [TestCase("S13.2.2_A17_T3.js", Description = "FunctionExpression containing \"with\" statement is admitted")]
        public void FunctionExpressionContainingWithStatementIsAdmitted(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A18_T1.js", Description = "Using arguments object within a \"with\" Expression that is nested in a function is admitted")]
        [TestCase("S13.2.2_A18_T2.js", Description = "Using arguments object within a \"with\" Expression that is nested in a function is admitted")]
        public void UsingArgumentsObjectWithinAWithExpressionThatIsNestedInAFunctionIsAdmitted(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A19_T1.js", Description = "Function\'s scope chain is started when it is declared")]
        [TestCase("S13.2.2_A19_T2.js", Description = "Function\'s scope chain is started when it is declared")]
        [TestCase("S13.2.2_A19_T3.js", Description = "Function\'s scope chain is started when it is declared")]
        [TestCase("S13.2.2_A19_T4.js", Description = "Function\'s scope chain is started when it is declared")]
        [TestCase("S13.2.2_A19_T5.js", Description = "Function\'s scope chain is started when it is declared")]
        [TestCase("S13.2.2_A19_T6.js", Description = "Function\'s scope chain is started when it is declared")]
        [TestCase("S13.2.2_A19_T7.js", Description = "Function\'s scope chain is started when it is declared")]
        [TestCase("S13.2.2_A19_T8.js", Description = "Function\'s scope chain is started when it is declared")]
        public void FunctionSScopeChainIsStartedWhenItIsDeclared(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A2.js", Description = "Since a function is an object, it might be set to [[Prototype]] property of a new created object through [[Construct]] property, but [[call]] property must fail with TypeError error")]
        public void SinceAFunctionIsAnObjectItMightBeSetToPrototypePropertyOfANewCreatedObjectThroughConstructPropertyButCallPropertyMustFailWithTypeErrorError(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [Category("ECMA 15.2.3.1")]
        [TestCase("S13.2.2_A3_T1.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. It gets the value of the [[Prototype]] property of the F(Denote it PROTO_VAL). If PROTO_VAL is not an object, sets the [[Prototype]] property of native ECMAScript object just created  to the original Object prototype object as described in 15.2.3.1")]
        [TestCase("S13.2.2_A3_T2.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. It gets the value of the [[Prototype]] property of the F(Denote it PROTO_VAL). If PROTO_VAL is not an object, sets the [[Prototype]] property of native ECMAScript object just created  to the original Object prototype object as described in 15.2.3.1")]
        public void WhenTheConstructPropertyForAFunctionObjectFIsCalledANewNativeECMAScriptObjectIsCreatedItGetsTheValueOfThePrototypePropertyOfTheFDenoteItPROTO_VALIfPROTO_VALIsNotAnObjectSetsThePrototypePropertyOfNativeECMAScriptObjectJustCreatedToTheOriginalObjectPrototypeObjectAsDescribedIn15231(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A4_T1.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. Gets the value of the [[Prototype]] property of the F(Denote it PROTO_VAL). If PROTO_VAL is an object, sets the [[Prototype]] property of native ECMAScript object just created to the PROTO_VAL")]
        [TestCase("S13.2.2_A4_T2.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. Gets the value of the [[Prototype]] property of the F(Denote it PROTO_VAL). If PROTO_VAL is an object, sets the [[Prototype]] property of native ECMAScript object just created to the PROTO_VAL")]
        public void WhenTheConstructPropertyForAFunctionObjectFIsCalledANewNativeECMAScriptObjectIsCreatedGetsTheValueOfThePrototypePropertyOfTheFDenoteItPROTO_VALIfPROTO_VALIsAnObjectSetsThePrototypePropertyOfNativeECMAScriptObjectJustCreatedToThePROTO_VAL(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A5_T1.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. Invoke the [[Call]] property of F, providing native ECMAScript object just created as the this value and providing the argument list passed into [[Construct]] as the argument values")]
        [TestCase("S13.2.2_A5_T2.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. Invoke the [[Call]] property of F, providing native ECMAScript object just created as the this value and providing the argument list passed into [[Construct]] as the argument values")]
        public void WhenTheConstructPropertyForAFunctionObjectFIsCalledANewNativeECMAScriptObjectIsCreatedInvokeTheCallPropertyOfFProvidingNativeECMAScriptObjectJustCreatedAsTheThisValueAndProvidingTheArgumentListPassedIntoConstructAsTheArgumentValues(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A6_T1.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. Invoke the [[Call]] property of F, providing just created native ECMAScript object as the this value and providing the argument list passed into [[Construct]] as the argument values. If Type( [[Call]] returned) is not Object then return passed as this into [[Call]] object")]
        [TestCase("S13.2.2_A6_T2.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. Invoke the [[Call]] property of F, providing just created native ECMAScript object as the this value and providing the argument list passed into [[Construct]] as the argument values. If Type( [[Call]] returned) is not Object then return passed as this into [[Call]] object")]
        public void WhenTheConstructPropertyForAFunctionObjectFIsCalledANewNativeECMAScriptObjectIsCreatedInvokeTheCallPropertyOfFProvidingJustCreatedNativeECMAScriptObjectAsTheThisValueAndProvidingTheArgumentListPassedIntoConstructAsTheArgumentValuesIfTypeCallReturnedIsNotObjectThenReturnPassedAsThisIntoCallObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A7_T1.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. Invoke the [[Call]] property of F, providing just created native ECMAScript object as the this value and providing the argument list passed into [[Construct]] as the argument values. If Type( [[Call]] returned) is an Object then return this just as obtained object")]
        [TestCase("S13.2.2_A7_T2.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. Invoke the [[Call]] property of F, providing just created native ECMAScript object as the this value and providing the argument list passed into [[Construct]] as the argument values. If Type( [[Call]] returned) is an Object then return this just as obtained object")]
        public void WhenTheConstructPropertyForAFunctionObjectFIsCalledANewNativeECMAScriptObjectIsCreatedInvokeTheCallPropertyOfFProvidingJustCreatedNativeECMAScriptObjectAsTheThisValueAndProvidingTheArgumentListPassedIntoConstructAsTheArgumentValuesIfTypeCallReturnedIsAnObjectThenReturnThisJustAsObtainedObject(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A8_T1.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. Invoke the [[Call]] property of F, providing just created native ECMAScript object as the this value and providing the argument list passed into [[Construct]] as the argument values. If Type( [[Call]] returned) is an Function then return this just as obtained function")]
        [TestCase("S13.2.2_A8_T2.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. Invoke the [[Call]] property of F, providing just created native ECMAScript object as the this value and providing the argument list passed into [[Construct]] as the argument values. If Type( [[Call]] returned) is an Function then return this just as obtained function")]
        [TestCase("S13.2.2_A8_T3.js", Description = "When the [[Construct]] property for a Function object F is called: A new native ECMAScript object is created. Invoke the [[Call]] property of F, providing just created native ECMAScript object as the this value and providing the argument list passed into [[Construct]] as the argument values. If Type( [[Call]] returned) is an Function then return this just as obtained function")]
        public void WhenTheConstructPropertyForAFunctionObjectFIsCalledANewNativeECMAScriptObjectIsCreatedInvokeTheCallPropertyOfFProvidingJustCreatedNativeECMAScriptObjectAsTheThisValueAndProvidingTheArgumentListPassedIntoConstructAsTheArgumentValuesIfTypeCallReturnedIsAnFunctionThenReturnThisJustAsObtainedFunction(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2.2")]
        [TestCase("S13.2.2_A9.js", Description = "Calling a function as a constructor is inadmissible as long as this.any_Function is called before it is declared")]
        public void CallingAFunctionAsAConstructorIsInadmissibleAsLongAsThisAny_FunctionIsCalledBeforeItIsDeclared(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [TestCase("S13.2_A1_T1.js", Description = "A \"prototype\" property is automatically created for every function")]
        [TestCase("S13.2_A1_T2.js", Description = "A \"prototype\" property is automatically created for every function")]
        public void APrototypePropertyIsAutomaticallyCreatedForEveryFunction(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [TestCase("S13.2_A2_T1.js", Description = "Nested function are admitted")]
        [TestCase("S13.2_A2_T2.js", Description = "Nested function are admitted")]
        public void NestedFunctionAreAdmitted(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [TestCase("S13.2_A3.js", Description = "When Function object(F) is constructed the length property of F is set to the number of formal properties specified in FormalParameterList")]
        public void WhenFunctionObjectFIsConstructedTheLengthPropertyOfFIsSetToTheNumberOfFormalPropertiesSpecifiedInFormalParameterList(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [TestCase("S13.2_A4_T1.js", Description = "When Function object(F) is constructed the following steps from 9 to 11 take place 9.Create a new object as would be constructed by the expression new Object(). 10. Set the constructor property of Result(9) to F. This property is given attributes { DontEnum }. 11. Set the \"prototype\" property of F to Result(9).")]
        [TestCase("S13.2_A4_T2.js", Description = "When Function object(F) is constructed the following steps from 9 to 11 take place 9.Create a new object as would be constructed by the expression new Object(). 10. Set the constructor property of Result(9) to F. This property is given attributes { DontEnum }. 11. Set the \"prototype\" property of F to Result(9).")]
        public void WhenFunctionObjectFIsConstructedTheFollowingStepsFrom9To11TakePlace9CreateANewObjectAsWouldBeConstructedByTheExpressionNewObject10SetTheConstructorPropertyOfResult9ToFThisPropertyIsGivenAttributesDontEnum11SetThePrototypePropertyOfFToResult9(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 13.2")]
        [Category("ECMA 15.3.3.1")]
        [TestCase("S13.2_A5.js", Description = "When Function object(F) is constructed the [[Prototype]] property of F is set to the original Function prototype object as specified in 15.3.3.1")]
        public void WhenFunctionObjectFIsConstructedThePrototypePropertyOfFIsSetToTheOriginalFunctionPrototypeObjectAsSpecifiedIn15331(string file)
        {
            RunFile(file);
        }
    }
}
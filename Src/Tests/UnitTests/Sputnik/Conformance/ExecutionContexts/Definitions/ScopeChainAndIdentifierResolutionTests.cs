// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.ExecutionContexts.Definitions
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ScopeChainAndIdentifierResolutionTests : SputnikTestFixture
    {
        public ScopeChainAndIdentifierResolutionTests()
            : base(@"Conformance\10_Execution_Contexts\10.1_Definitions\10.1.4_Scope_Chain_and_Identifier_Resolution")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 10.1.4")]
        [TestCase("S10.1.4_A1_T1.js", Description = "Every execution context has associated with it a scope chain. A scope chain is a list of objects that are searched when evaluating an Identifier")]
        [TestCase("S10.1.4_A1_T2.js", Description = "Every execution context has associated with it a scope chain. A scope chain is a list of objects that are searched when evaluating an Identifier")]
        [TestCase("S10.1.4_A1_T3.js", Description = "Every execution context has associated with it a scope chain. A scope chain is a list of objects that are searched when evaluating an Identifier")]
        [TestCase("S10.1.4_A1_T4.js", Description = "Every execution context has associated with it a scope chain. A scope chain is a list of objects that are searched when evaluating an Identifier")]
        [TestCase("S10.1.4_A1_T5.js", Description = "Every execution context has associated with it a scope chain. A scope chain is a list of objects that are searched when evaluating an Identifier")]
        [TestCase("S10.1.4_A1_T6.js", Description = "Every execution context has associated with it a scope chain. A scope chain is a list of objects that are searched when evaluating an Identifier")]
        [TestCase("S10.1.4_A1_T7.js", Description = "Every execution context has associated with it a scope chain. A scope chain is a list of objects that are searched when evaluating an Identifier")]
        [TestCase("S10.1.4_A1_T8.js", Description = "Every execution context has associated with it a scope chain. A scope chain is a list of objects that are searched when evaluating an Identifier")]
        [TestCase("S10.1.4_A1_T9.js", Description = "Every execution context has associated with it a scope chain. A scope chain is a list of objects that are searched when evaluating an Identifier")]
        public void EveryExecutionContextHasAssociatedWithItAScopeChainAScopeChainIsAListOfObjectsThatAreSearchedWhenEvaluatingAnIdentifier(string file)
        {
            RunFile(file);
        }
    }
}
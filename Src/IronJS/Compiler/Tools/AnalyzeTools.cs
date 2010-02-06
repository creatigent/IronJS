﻿using System.Collections.Generic;
using IronJS.Compiler.Ast;
using IronJS.Runtime2.Js;

namespace IronJS.Compiler.Tools {
    internal static class AnalyzeTools {
        internal static INode GetVariable(Stack<Function> stack, string name) {
            Function current = stack.Peek();
            Stack<Function> missingStack = new Stack<Function>();

            Variable variable;
            foreach(Function function in stack) {
                if (function.Variables.TryGetValue(name, out variable)) {
                    if (function == current)
                        return variable;

                    if (variable is Local) {
                        variable.IsClosedOver = true;
                        variable.ForceType(IjsTypes.Dynamic);

                        foreach (Function traversed in missingStack) {
                            traversed[name] = new Closed(traversed, name);
                        }

                        return current.Variables[name];
                    }
                } else {
                    missingStack.Push(function);
                }
            }

            return new Global(name);
        }
    }
}

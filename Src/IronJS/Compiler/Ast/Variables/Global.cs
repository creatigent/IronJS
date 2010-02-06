﻿using System;
using System.Collections.Generic;
using System.Text;
using IronJS.Tools;

namespace IronJS.Compiler.Ast {
    public class Global : Node {
        public string Name { get; protected set; }

        public Global(string name) 
            : base(NodeType.Global, null) {
            Name = name;
        }

        public override void Write(StringBuilder writer, int depth) {
            writer.AppendLine(StringTools.Indent(depth * 2) + "(Global " + Name + ")");
        }
    }
}

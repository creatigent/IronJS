﻿namespace IronJS.Compiler

open IronJS
open IronJS.Aliases
open IronJS.Tools
open IronJS.Compiler

open System.Dynamic

module Assign = 

    let internal build (ctx:Context) left right =
      let value = ctx.Builder2 right

      match left with
      | Ast.Global(name, scopeLevels) -> 
        if scopeLevels.Global = 0 
          then ctx.TemporaryTypes.[name] <- value.Type
               Variables.Global.assign ctx name value
          else DynamicScope.setGlobalValue ctx name value

      | Ast.Closure(name, scopeLevels) -> 
        if scopeLevels.Global = 0 
          then ctx.TemporaryTypes.[name] <- value.Type
               Variables.Closure.assign ctx name value
          else DynamicScope.setClosureValue ctx name value

      | Ast.Variable(name, scopeLevels) -> 
        if scopeLevels.Local = 0 
          then ctx.TemporaryTypes.[name] <- value.Type
               Variables.Local.assign ctx name value
          else DynamicScope.setLocalValue ctx name value

      | Ast.Property(target, name) -> CallSites.setMember ctx (ctx.Builder ctx target) name value
      | _ -> failwith "Assignment for '%A' is not defined" left
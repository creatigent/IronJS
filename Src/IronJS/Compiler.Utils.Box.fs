﻿namespace IronJS.Compiler.Utils

open IronJS
open IronJS.Aliases
open IronJS.Tools
open IronJS.Tools.Dlr
open IronJS.Compiler

module Box =

  let fieldByJsType (expr:Et) typeCode = 
    match typeCode with
    | Types.Boolean   -> Expr.field expr "Bool"
    | Types.Double    -> Expr.field expr "Double"
    | Types.Integer   -> Expr.field expr "Int"

    | Types.Clr
    | Types.Null
    | Types.Undefined -> Expr.field expr "Clr"

    #if FAST_CAST
    | Types.String    -> Expr.field expr "String"
    | Types.Object    -> Expr.field expr "Object"
    | Types.Function  -> Expr.field expr "Func"
    | Types.Array     -> Expr.field expr "Array"
    #else
    | Types.String    -> Expr.field expr "Clr"
    | Types.Object    -> Expr.field expr "Clr"
    | Types.Function  -> Expr.field expr "Clr"
    | Types.Array     -> Expr.field expr "Clr"
    #endif

    | _ -> failwith "Invalid js type: '%A'" typeCode

  let fieldByClrType (expr:Et) typ = 
    fieldByJsType expr (Utils.Type.clrToJs typ)

  let fieldByClrTypeT<'a> (expr:Et) = 
    fieldByClrType expr typeof<'a>

  let typeField (target:Et) =
    Expr.field target "Type"

  let setType (target:Et) (typ:ClrType)  = 
    let typ = Expr.constant (Utils.Type.clrToJs typ)
    Expr.assign (typeField target) typ

  let setTypeT<'a> target = 
    setType target typeof<'a>

  let setValue (target:Et) (value:Et) =
    let jsType = Utils.Type.clrToJs value.Type
    Expr.assign (fieldByJsType target jsType) value
  
  let isWrapped (expr:Et) = 
    expr.Type = typeof<Runtime.Box>

  let assign (left:Et) (right:Et) =
    if not (left.Type = typeof<Runtime.Box>) then
      failwith "Left expression is not a Runtime.Box"

    if right.Type = typeof<Runtime.Box> 
      then Expr.assign left right
      else Expr.block [setValue left right; setType left right.Type; Expr.void']

  let wrap (expr:Et) =
    if isWrapped expr then expr 
    else
      Expr.blockTmpT<Runtime.Box> (
        fun tmp -> [setValue tmp expr; setType tmp expr.Type; tmp]
      )

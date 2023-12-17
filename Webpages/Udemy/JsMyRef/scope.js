"use strict";
console.log("Scope file loaded");
let GlobalVar = "Global Desc";

function ModifyGlobalVar() {
  GlobalVar = "Func Desc";
}
ModifyGlobalVar();
console.log(GlobalVar); //Prints """Func Desc"""

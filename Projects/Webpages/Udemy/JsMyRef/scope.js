"use strict";
console.log("Scope file loaded");
let GlobalVar = "Global Desc";

function ModifyGlobalVar() {
  GlobalVar = "Func Desc";
}
ModifyGlobalVar();
console.log(GlobalVar); //Prints """Func Desc"""

//THIS KEYWORD
const jonas = {
  year: 1991,
  calcAge: function () {
    console.log(this); //Represents the object using which method is called
    console.log(2037 - this.year);
  },
};

jonas.calcAge();
const matilda = {
  year: 2017,
};

matilda.calcAge = jonas.calcAge;
matilda.calcAge(); //RETURNS """""20"""""
const f = jonas.calcAge;
//f(); THIS WILL THROW ERROR. BECAUSE OF """this.year""" usage

const ArrowvNormalFunction = {
  ObjectVar: "Im inside obj",
  normalFun: function () {
    console.log("Normal fun");
    console.log(this); //Returns ArrowvNormalFunction object
  },
  arrowFun: () => {
    console.log("Arrow fun");
    console.log(this); //Returns window object
  },
};

console.log("Arror vs normal function. This obj comparison");
ArrowvNormalFunction.normalFun();
ArrowvNormalFunction.arrowFun();

//RECOMMENDED TO USE NORMAL FUNCTION IF this keyword usage is required

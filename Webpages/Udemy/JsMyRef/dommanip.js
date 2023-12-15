//"use strict";

console.log("Dom page loaded");

console.log(document.querySelector(".message"));

console.log("Before manip " + document.querySelector(".message").textContent);
document.querySelector(".message").textContent = "DOM Manipulated text";
console.log("After manip " + document.querySelector(".message").textContent);

let classNameUserInput = ".userinput";
console.log("Before manip " + document.querySelector(classNameUserInput).value);
document.querySelector(classNameUserInput).value = "DOM Manipulated user input";
console.log("After manip " + document.querySelector(classNameUserInput).value);

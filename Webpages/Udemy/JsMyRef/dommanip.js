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

//Adding EVENT LISTENER
let TxtFieldData = document.querySelector(classNameUserInput).value;
//Param1: Action, Param2: Method to be executed when event is triggered
document.querySelector(".btnclick").addEventListener("click", function () {
  console.log("button click event is triggered");
  document.querySelector("body").style.backgroundColor = "#454B1B"; //To CHANGE THE CSS
  document.querySelector(".printuserip").textContent = TxtFieldData; //This will not get updated always
});

//"""querySelectorAll""" method is used to fetch all elements fo this class
let GetAllButtons = document.querySelectorAll(".groupbtn");
console.log(GetAllButtons);

for (let i = 0; i < GetAllButtons.length; i++) {
  GetAllButtons[i].addEventListener("click", function () {
    console.log("button clicked");
    GetAllButtons[i].classList.add("groupbtn-color");

    //TO TOGGLE THE CLASS
    //GetAllButtons[i].classList.toggle("groupbtn-color");
  });
}

//Listen for KEY PRESS event
document.addEventListener("keydown", function (e) {
  console.log("Key pressed:" + e.key);
});

//FETCH DATA USING ID
//IN QUERY SELECTOR USE # if its ID
//IN CASE OF getElementById, PROVIDE ID NAME
document.querySelector("#uibutton").addEventListener("click", function () {
  let UIInput = document.getElementById("uiinput").value;
  document.getElementById("uispan").textContent = UIInput;
});

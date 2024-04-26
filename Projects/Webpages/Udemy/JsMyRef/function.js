console.log("JS function script loaded");

function withoutparam() {}

function withparam(input1, input2) {}

//Function expression
const funcexp = function (input1, input2) {
  return input1 + input2;
};
console.log(funcexp(10, 20));

//Arrow function
const arrowfun = (input1) => (input1 = input1 + 100);
console.log(arrowfun(10)); //110

const arrowfunwithstm = (input1, input2) => {
  let newinp = input1 + input2;
  return newinp;
};
console.log(arrowfunwithstm(10, 20));

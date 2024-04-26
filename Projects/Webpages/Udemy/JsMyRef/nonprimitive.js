console.log("non primitive js");
let modules = ["MPP", "TPT", "TPR", "BPP"];
console.log(modules);
console.log(modules[10]); //returns undefined
console.log("Print after index out of bounds"); //This will be printed

let projects = new Array("C2", "C3", "C2V");

projects.push("MPP");
projects.unshift("C1"); //To add element at the beginning of array
console.log(projects);

console.log("pop removed " + projects.pop() + " from array"); //Removes last element from array
console.log("shift removed " + projects.shift() + " from array"); //Removes first element from array
console.log(projects);

console.log(projects.includes("thread")); //Check for the presence of element

const modulesconst = ["mpp", "c3"];
console.log("constant " + modulesconst);
console.log(modulesconst);
modulesconst.push("c2v");
console.log(modulesconst);
//modulesconst = []; Will throw error. Assignment to constant variable

//CLASS - OBJECT
const ProjectInfo = {
  name: "C2V",
  ProjOwner: "ABC",
  ProgramManager: "YYY",
  Years: 1,
  MOIs: ["DP", "PD"],

  //OBJECT METHOD
  AdditionalInfo: function (desc) {
    return this.name + " " + desc;
  },
};
console.log(ProjectInfo);
console.log(ProjectInfo.name); //Using dot operator
const KeyDesc = "Manager";
console.log(ProjectInfo["Program" + KeyDesc]); //using square brackets. Takes any variable as input

//To add new properties
ProjectInfo.Status = "Certified";
ProjectInfo["users"] = 100;
console.log(ProjectInfo);

//Calling oject method
console.log(ProjectInfo.AdditionalInfo("test solution"));
console.log(ProjectInfo["AdditionalInfo"]("test solution using brackets"));

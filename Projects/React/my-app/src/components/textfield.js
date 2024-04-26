import { useState } from "react";

//Since state vaiable is binded to input value, without binding the
//onChange event the text will be always empty. I.e the default value
//of "Desc" state variable

export default function TextField() {
  const [Desc, SetDesc] = useState("");
  const [Count, SetCount] = useState(0);

  function handleSubmit() {
    //SetCount((count) => count + 1);
    SetCount(Count + 1);
    //alert("submit button is clicked");
  }
  return (
    <>
      <label>Enter Your Text Here </label>
      <input
        type="text"
        value={Desc}
        onChange={(e) => {
          SetDesc(e.target.value);
        }}
      ></input>
      <br></br>
      <div>
        <button onClick={handleSubmit}>Submit</button>
        <br></br>
        <label>
          Submit button is clicked <span>{Count}</span> times
        </label>
      </div>
    </>
  );
}

import { useState } from "react";

export default function Square({ value, eventHndlr }) {
  //   const [value, setValue] = useState(null);

  return (
    <>
      <button className="square" onClick={eventHndlr}>
        {value}
      </button>
    </>
  );
}

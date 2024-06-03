import { useState } from "react";
// import Square from "./Square";
import Square from "../TictactoeB/Square";

export default function Tictactoe({ nextTurnX, Currentsquares, handlePlay }) {
  //Whenever user clicks on any square
  function handleClick(squareIndex) {
    console.log("calling on click");
    if (Currentsquares[squareIndex] || calculateWinner(Currentsquares)) return; //Retun for non null case

    const nextSquares = Currentsquares.slice();

    if (nextTurnX) {
      nextSquares[squareIndex] = "X";
    } else {
      nextSquares[squareIndex] = "O";
    }
    handlePlay(nextSquares);
    // setNextTurn(!nextTurnX);
    // console.log("Index:" + squareIndex);
  }

  console.log("Calling calculate winner");
  const winner = calculateWinner(Currentsquares);
  let status;
  if (winner) {
    status = "Winner: " + winner;
  } else {
    status = "Next player: " + (nextTurnX ? "X" : "O");
  }
  return (
    <>
      <div className="status">{status}</div>
      <div className="board-row">
        <Square
          value={Currentsquares[0]}
          eventHndlr={() => handleClick(0)}
        ></Square>
        <Square
          value={Currentsquares[1]}
          eventHndlr={() => handleClick(1)}
        ></Square>
        <Square
          value={Currentsquares[2]}
          eventHndlr={() => handleClick(2)}
        ></Square>
      </div>
      <div className="board-row">
        <Square
          value={Currentsquares[3]}
          eventHndlr={() => handleClick(3)}
        ></Square>
        <Square
          value={Currentsquares[4]}
          eventHndlr={() => handleClick(4)}
        ></Square>
        <Square
          value={Currentsquares[5]}
          eventHndlr={() => handleClick(5)}
        ></Square>
      </div>
      <div className="board-row">
        <Square
          value={Currentsquares[6]}
          eventHndlr={() => handleClick(6)}
        ></Square>
        <Square
          value={Currentsquares[7]}
          eventHndlr={() => handleClick(7)}
        ></Square>
        <Square
          value={Currentsquares[8]}
          eventHndlr={() => handleClick(8)}
        ></Square>
      </div>
    </>
  );

  function calculateWinner(squares) {
    const lines = [
      [0, 1, 2],
      [3, 4, 5],
      [6, 7, 8],
      [0, 3, 6],
      [1, 4, 7],
      [2, 5, 8],
      [0, 4, 8],
      [2, 4, 6],
    ];
    for (let i = 0; i < lines.length; i++) {
      const [a, b, c] = lines[i];
      if (
        squares[a] &&
        squares[a] === squares[b] &&
        squares[a] === squares[c]
      ) {
        return squares[a];
      }
    }
    return null;
  }
}

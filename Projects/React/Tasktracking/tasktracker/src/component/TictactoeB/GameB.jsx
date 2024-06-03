import { useState } from "react";
import Tictactoe from "./Tictactoe";

export default function GameB() {
  // const [IsXNextPlayer, setNextPlayer] = useState(true);
  const [history, setHistory] = useState([Array(9).fill(null)]);
  const [currentMove, setCurrentMove] = useState(0);
  const IsXNextPlayer = currentMove % 2 === 0;
  const currentSquares = history[currentMove];

  function HandlePlay(nextSquare) {
    const nextHistory = [...history.slice(0, currentMove + 1), nextSquare];
    setHistory(nextHistory);
    setCurrentMove(nextHistory.length - 1);
    // setNextPlayer(!IsXNextPlayer);
  }

  function jumpTo(nextMove) {
    setCurrentMove(nextMove);
    // setNextPlayer(nextMove % 2 === 0);
  }

  const Moves = history.map((squares, move) => {
    let description;
    if (move > 0) {
      description = "Go to move #" + move;
    } else {
      description = "Go to game start";
    }
    return (
      <>
        <li key={move}>
          <button onClick={() => jumpTo(move)}>{description}</button>
        </li>
      </>
    );
  });

  return (
    <>
      <div>
        <Tictactoe
          nextTurnX={IsXNextPlayer}
          Currentsquares={currentSquares}
          handlePlay={HandlePlay}
        ></Tictactoe>
      </div>
      <div>
        <ol>{Moves}</ol>
      </div>
    </>
  );
}

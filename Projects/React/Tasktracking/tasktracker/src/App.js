import logo from "./logo.svg";
// import "./App.css";
import Game from "./component/Game";
import "./styles.css";
import Tictactoe from "./component/TictactoeB/Tictactoe";
import GameB from "./component/TictactoeB/GameB";
import Grocerymain from "./component/grocery/Grocerymain";
function App() {
  return (
    <div className="App">
      {/* <Tictactoe></Tictactoe> */}
      {/* <Game></Game> */}
      {/* <GameB></GameB> */}
      <Grocerymain></Grocerymain>
    </div>
  );
}

export default App;

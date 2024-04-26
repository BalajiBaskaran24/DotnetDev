import React from "react";
import logo from "./logo.svg";
import "./App.css";
import Title from "./components/title";
import DBAccess from "./common/DBAccess";

function App() {
  return (
    <div className="App">
      <DBAccess></DBAccess>
    </div>
  );
}

export default App;

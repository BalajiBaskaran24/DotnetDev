import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import { createRoot } from "react-dom/client";
import SampleContextComponent from "./components/contextsample";
import DisplayEmployee from "./components/loopsample";
import Toolbar from "./components/eventssample";
import TextField from "./components/textfield";

const root = createRoot(document.getElementById("root"));
const element = <TextField></TextField>;
root.render(element);

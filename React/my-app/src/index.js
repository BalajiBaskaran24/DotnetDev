import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import { createRoot } from "react-dom/client";
import SampleContextComponent from "./components/contextsample";
import DisplayEmployee from "./components/loopsample";
import Toolbar from "./components/eventssample";

const root = createRoot(document.getElementById("root"));
const element = <Toolbar></Toolbar>;
root.render(element);

class Employee extends React.Component {
  constructor(props) {
    super(props);
    console.log(this.props);
    this.state = {
      updateSalary: null,
    };
  }

  getUpdatedSalary = (salary) => {
    this.setState({ updateSalary: salary });
  };

  render() {
    console.log(this.props + "in render method");
    const listdata = [
      { id: "1", Name: "Bala" },
      { id: "2", Name: "Ji" },
      { id: "3", Name: "Bas" },
    ];
    return (
      <div>
        {/* <SampleContextComponent></SampleContextComponent>
        <p>Updated salary: {this.state.updateSalary}</p>
        <Salary
          basic={this.props.basic}
          hra={this.props.hra}
          bonus={this.props.bonus}
          OnSalaryChangedProp={this.getUpdatedSalary}
        ></Salary> */}
      </div>
    );
  }
}

class Salary extends React.Component {
  constructor(props) {
    super(props);
  }

  updateSalary = () => {
    let UpdatedSalary =
      parseInt(this.refs.basicR.value) +
      parseInt(this.refs.HRAR.value) +
      parseInt(this.refs.BonusR.value);
    console.log(UpdatedSalary);
    this.props.OnSalaryChangedProp(UpdatedSalary);
  };
  render() {
    return (
      <div>
        <label>
          Basic:{" "}
          <input
            type="text"
            ref="basicR"
            defaultValue={this.props.basic}
          ></input>
        </label>
        <br></br>
        <label>
          HRA:{" "}
          <input type="text" ref="HRAR" defaultValue={this.props.hra}></input>
        </label>
        <br></br>
        <label>
          Bonus:{" "}
          <input
            type="text"
            ref="BonusR"
            defaultValue={this.props.bonus}
          ></input>
        </label>
        <br></br>
        <button onClick={this.updateSalary}>Update Data</button>
      </div>
    );
  }
}

// const element = <Employee basic="100000" hra="20000" bonus="15000"></Employee>;
// const root = createRoot(document.getElementById("root"));
// root.render(element);

// const element = (
//   <DisplayEmployee
//     data={[
//       { id: "1", Name: "Bala" },
//       { id: "2", Name: "Ji" },
//       { id: "3", Name: "Bas" },
//     ]}
//   ></DisplayEmployee>
// );
// const root = createRoot(document.getElementById("root"));
// root.render(element);

import React from "react";
import ReactDOM from "react-dom/client";

//Using CONTEXT

const SampleContext = React.createContext({
  data: { ConData: "Temp" },
  CallBackFromChildCmp: () => {},
});

class SampleContextComponent extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      data: { ConData: "Data printed using context" },
      CallBackFromChildCmp: this.CallBackFromChildCmpLoc,
    };
  }

  CallBackFromChildCmpLoc = () => {
    console.log("called");
    this.setState({ data: { ConData: "Update called from children" } });
  };

  UpdateContext = () => {
    console.log("called upd");
    this.setState({ data: { ConData: "Data updated by Level 1 app" } });
  };
  render() {
    return (
      <div>
        {/* --- Samplecontext.Provider allows consuming component to subscribe to context changes
            --- value property is used to pass data to components that are descendent of this provider
            --- Descendent of this provider will re-render if whenever the provider value changes*/}
        <button onClick={this.UpdateContext}>Update context from Level1</button>
        <SampleContext.Provider value={this.state}>
          <Level2></Level2>
        </SampleContext.Provider>
      </div>
    );
  }
}

class Level2 extends React.Component {
  static contextType = SampleContext;
  constructor(props) {
    super(props);
  }

  render() {
    return (
      <div>
        <p>Data obtained using context: {this.context.data.ConData}</p>
        <Level3></Level3>
      </div>
    );
  }
}

class Level3 extends React.Component {
  static contextType = SampleContext;
  constructor(props) {
    super(props);
  }

  render() {
    //console.log(this.context.CallBackFromChildCmp);
    return (
      <div>
        <p>Level 3</p>
        <p>Data obtained using context: {this.context.data.ConData}</p>

        {/* Below line invokes callback which is a state variable(arrow function) of parent   */}
        <button onClick={this.context.CallBackFromChildCmp}>
          Update context from child
        </button>
      </div>
    );
  }
}

export default SampleContextComponent;

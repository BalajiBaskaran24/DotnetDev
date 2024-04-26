import { configureStore } from "@reduxjs/toolkit";
import QuestionsReducer from "./slices/data";
import { createStore, combineReducers } from "redux";

const rootReducer = combineReducers({ Users: QuestionsReducer });

const store = createStore(rootReducer);

export default store;

// import { makeAutoObservable } from "mobx";

// class HelperMobx {
//   LoggedIn: boolean; //Login is successful
//   constructor() {
//     this.LoggedIn = false;
//     makeAutoObservable(this);
//   }

//   setnextpageLogin(value: boolean) {
//     this.LoggedIn = value;
//   }
// }

// const helperMobx = new HelperMobx();
// export default helperMobx;

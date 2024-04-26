import Topics from "@/components/topics";
import { createSlice } from "@reduxjs/toolkit";

const initialUserState = {
  SelectedTopic: "",
  SelectedSection: "",
  AllQuestions: [{}],
};

export default function QuestionsReducer(
  state = initialUserState,
  action: any
) {
  switch (action.type) {
    case "data/updatesection":
      console.log("updating login state with " + action);
      return {
        ...state,
        SelectedSection: action.payload,
      };
    case "data/updatetopic":
      return {
        ...state,
        SelectedTopic: action.payload,
      };
    case "data/addquestion":
      return {
        ...state,
        AllQuestions: [{ ...state.AllQuestions }, action.payload],
      };
    default:
      return state;
  }
}

function updatesection(section: any) {
  return { type: "data/updatesection", payload: section };
}

function updatetopic(topic: any) {
  return { type: "data/updatetopic", payload: topic };
}

function addquestion(question: any) {
  return { type: "data/addquestion", payload: question };
}

export { updatesection, updatetopic, addquestion };

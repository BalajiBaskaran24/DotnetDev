"use client";
import { addquestion } from "@/datastore/slices/data";
import { NewQuestion } from "@/lib/actions";
import { useState } from "react";
import { useDispatch } from "react-redux";

const SubmitQuestion: React.FC = () => {
  return (
    <>
      <form action={NewQuestion}>
        <h1>Submit QA </h1>
        <label>Question:</label>
        <textarea
          name="question"
          rows={4}
          cols={50}
          placeholder="question"
        ></textarea>
        <br></br>
        <label>Answer:</label>
        <textarea
          name="answer"
          rows={4}
          cols={50}
          placeholder="answer"
        ></textarea>
        <br></br>
        <input type="submit" value="Submit"></input>
      </form>
    </>
  );
};

export default SubmitQuestion;

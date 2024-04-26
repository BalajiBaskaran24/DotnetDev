"use client";
import { useEffect } from "react";
import { useSelector } from "react-redux";
const QuestionAns: React.FC = () => {
  // useEffect(() => {
  //   console.log("calling use effect");
  // }, []);
  const AllQuestions = [{ ques: "", ans: "" }];
  //useSelector((state: any) => state.Users.AllQuestions);
  return (
    <>
      <h1> List of available QA</h1>
      {/* <button onClick={() => console.log("invoked on click")}>Sample</button> */}
      <ul>
        {AllQuestions.map((questions, index) => (
          // Key should be unique for each sibling. It's usually best to use a unique ID.
          // Using index as key is not recommended if the list can change order, but it's okay for static lists.
          <li
            // className={Styles.li}
            key={index}
          >
            <p>{questions.ques}</p>
            <p>{questions.ans}</p>
          </li>
        ))}
      </ul>
    </>
  );
};

export default QuestionAns;

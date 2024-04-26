import QuestionAns from "../components/questionanswers";
import Sections from "../components/sections";
import SubmitQuestion from "../components/submitquestion";
import Topics from "../components/topics";
export default function Page() {
  return (
    <>
      <div>
        <Topics></Topics>
      </div>
      <div>
        <Sections></Sections>
      </div>
      <div>
        <SubmitQuestion></SubmitQuestion>
      </div>
      <div>
        <QuestionAns></QuestionAns>
      </div>
    </>
  );
}

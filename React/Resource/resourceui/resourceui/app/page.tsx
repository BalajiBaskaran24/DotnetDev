import QuestionAns from "../pages/questionanswers";
import Sections from "../pages/sections";
import SubmitQuestion from "../pages/submitquestion";
import Topics from "../pages/topics";
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

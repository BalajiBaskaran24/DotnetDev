const SubmitQuestion: React.FC = () => {
  return (
    <>
      <h1>Submit QA </h1>
      <label>Question:</label>
      <textarea
        name="message"
        rows={4}
        cols={50}
        placeholder="question"
      ></textarea>
      <br></br>
      <label>Answer:</label>
      <textarea
        name="message"
        rows={4}
        cols={50}
        placeholder="answer"
      ></textarea>
      <br></br>
      <button>Submit</button>
    </>
  );
};

export default SubmitQuestion;

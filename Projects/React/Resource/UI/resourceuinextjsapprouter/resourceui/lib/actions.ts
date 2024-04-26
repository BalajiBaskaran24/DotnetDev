"use server";

import api from "@/APImanagement/CommonAPI";

export async function NewQuestion(formdata) {
  const data = {
    Ques: formdata.get("question"),
    Answer: formdata.get("answer"),
  };
  console.log(data);
  api.putAPI(
    "Resource/PutQuestion",
    data,
    (response: any) => {},
    (err: any) => {}
  );
}

import React from "react";
import type { InferGetServerSidePropsType, GetServerSideProps } from "next";
import { json } from "stream/consumers";

export async function getStaticProps() {
  console.log("static props method");
  return { props: { topics: ["t1", "t2"] } };
}

function Topics(props) {
  return (
    <>
      <h1>Topics</h1>
      {/* <h2>Data {JSON.stringify(props.topics)}</h2>
      {console.log("object is " + JSON.stringify(props.topics))} */}
    </>
  );
}
export default Topics;

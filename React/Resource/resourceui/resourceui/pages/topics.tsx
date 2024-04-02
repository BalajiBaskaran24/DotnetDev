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
      <h2>Data {JSON.stringify(props.topics)}</h2>
      {console.log("object is " + JSON.stringify(props.topics))}
    </>
  );
}
export default Topics;

// import React from "react";
// import type { InferGetServerSidePropsType, GetServerSideProps } from "next";

// type TopicInfo = {
//   topics: string[];
// };

// export const getServerSideProps = (async () => {
//   // Fetch data from external API
//   // const res = await fetch("https://api.github.com/repos/vercel/next.js");
//   // const repo: TopicInfo = await res.json();
//   // Pass data to the page via props
//   console.log("calling get server");
//   const repo: TopicInfo = await { topics: ["t1", "t2"] };
//   return { props: { repo } };
// }) satisfies GetServerSideProps<{ repo: TopicInfo }>;

// const Topics: React.FC<
//   InferGetServerSidePropsType<typeof getServerSideProps>
// > = ({ repo }) => {
//   return (
//     <>
//       <h1>Topics</h1>
//       {console.log("object is " + repo)}
//       {/* {repo.topics.map((data) => (
//         <li>{data}</li>
//       ))} */}
//     </>
//   );
// };

// export default Topics;

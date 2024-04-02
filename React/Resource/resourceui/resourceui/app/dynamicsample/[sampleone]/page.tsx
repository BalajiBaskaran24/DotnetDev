import React from "react";
// Define the expected shape of `params`
interface SampleOneParams {
  sampleone: string;
}

// Annotate the props with the expected type
interface SampleOnePageProps {
  params: SampleOneParams;
}

// Annotate the function parameter with the type
const SampleOnePage: React.FC<SampleOnePageProps> = ({ params }) => {
  console.log(params);
  return <h1>Sample one: Called by {params.sampleone}</h1>;
};

export default SampleOnePage;

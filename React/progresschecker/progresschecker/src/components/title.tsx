import React from "react";

interface Props {
  name: string;
}

const Title: React.FC<Props> = ({ name }) => {
  return <div>{name}</div>;
};

export default Title;

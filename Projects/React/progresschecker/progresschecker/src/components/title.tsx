import React from "react";

interface data {
  name: string;
}

const Title: React.FC<data> = ({ name }) => {
  return <div>{name}</div>;
};

export default Title;

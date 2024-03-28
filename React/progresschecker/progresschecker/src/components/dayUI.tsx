import React from "react";
import { Day } from "../models/trackermodels";

const DayUI: React.FC<Day> = (day) => {
  {
  }
  return (
    <li>
      {day.Date.toLocaleString().split("T")[0]}: Completed{" "}
      {day.NumberOfPartsCompleted} parts
    </li>
  );
};

export default DayUI;

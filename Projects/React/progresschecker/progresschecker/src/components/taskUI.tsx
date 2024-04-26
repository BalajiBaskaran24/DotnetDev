import React from "react";
import Title from "./title";
import { Task } from "../models/trackermodels";
import DayUI from "./dayUI";

const GetDateFormat = (date: Date): string => {
  const Datestring = date.toLocaleString().split("T")[0];
  return Datestring !== "0001-01-01" ? Datestring : "Not started";
};

const TaskUI: React.FC<Task> = (task) => {
  return (
    <div>
      <p>Desc: {task.Description}</p>
      <p>Total Parts: {task.TotalParts}</p>
      <div>
        <p>Daily Summary</p>
        <ul>
          {task.DailyActivities !== undefined &&
          task.DailyActivities.length > 0 ? (
            task.DailyActivities.map((dayinfo) => <DayUI {...dayinfo}></DayUI>)
          ) : (
            <li>No activities</li>
          )}
        </ul>
      </div>
    </div>
  );
};

export default TaskUI;

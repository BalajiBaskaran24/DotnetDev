import React, { useEffect, useState } from "react";
import { TasksInfo, Task, Day, Summary } from "../models/trackermodels"; // Adjust the import path as necessary
import { json } from "stream/consumers";
import TaskUI from "../components/taskUI";

const DBAccess: React.FC = () => {
  const [tasks, setEvents] = useState<Task[]>([]);

  useEffect(() => {
    fetch("http://localhost:3003/events")
      .then((response) => response.json())
      .then((data) => setEvents(data));
  }, []);

  const calculateDuration = (startDate: string, endDate: string) => {
    const start = new Date(startDate).getTime();
    const end = new Date(endDate).getTime();
    return end - start; // Duration in milliseconds
  };

  return (
    <div className="flashcards">
      {tasks.map((task: Task, index: number) => (
        <TaskUI {...task}></TaskUI>
      ))}
    </div>
  );
};

export default DBAccess;

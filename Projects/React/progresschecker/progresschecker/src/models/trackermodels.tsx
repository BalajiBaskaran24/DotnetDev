export interface TasksInfo {
  id?: string; // Assuming the ID is optional when creating new instances but required once saved in the database
  allTasks: Task[];
}

export interface Task {
  taskId?: string; // Assuming taskId is generated or assigned later, hence optional
  name: string;
  Description: string;
  TotalParts: number;
  DailyActivities: Day[];
  Summary: Summary;
}

export interface Day {
  Desc: string;
  NumberOfPartsCompleted: number;
  Date: Date | string; // Depending on how you handle dates, you might want to use string (for ISO strings) or Date objects
}

export interface Summary {
  StartDate: Date;
  completionDate: Date | string;
}

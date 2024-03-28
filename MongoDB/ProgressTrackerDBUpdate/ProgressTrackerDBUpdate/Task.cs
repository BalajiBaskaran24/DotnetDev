using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Operations;

namespace ProgressTrackerDBUpdate
{
    public class TasksInfo
    {
        public TasksInfo()
        {
            AllTasks = new();
        }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public List<Task> AllTasks { get; set; }
    }

    public class Task
    {
        public Task()
        {
            DailyActivities = new();
            Summary = new();
        }
        public string TaskId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public int TotalParts { get; set; }

        public List<Day> DailyActivities { get; set; }

        public Summary Summary { get; set; }
    }


    public class Day
    {
        public string Desc;

        public int NumberOfPartsCompleted;

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }
    }

    public class Summary
    {
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime StartDate { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CompletionDate { get; set; }
    }
}

using Microsoft.Extensions.Logging;
using MongoDB.Driver;

namespace ProgressTrackerDBUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            TasksInfo AllTasks = new TasksInfo();
            Task ReactDev = new Task();
            ReactDev.Description = "Udemy course on React by Jonas";
            ReactDev.TotalParts = 411;
            ReactDev.Summary.StartDate = new DateTime(2024, 2, 19);
            ReactDev.DailyActivities.Add(new Day() { Date = new DateTime(2024, 2, 21), NumberOfPartsCompleted = 20 });
            ReactDev.DailyActivities.Add(new Day() { Date = new DateTime(2024, 2, 24), NumberOfPartsCompleted = 10 });
            ReactDev.DailyActivities.Add(new Day() { Date = new DateTime(2024, 2, 27), NumberOfPartsCompleted = 30 });
            AllTasks.AllTasks.Add(ReactDev);
            Task JSDev = new Task();
            JSDev.Description = "Udemy course on JS by Jonas";
            JSDev.TotalParts = 329;


            var client = new MongoClient("mongodb://localhost:27017"); // Change this to your MongoDB connection string
            var database = client.GetDatabase("ProgressTracker");
            var collection = database.GetCollection<Task>("TasksInfo");

            collection.InsertOne(ReactDev);
            collection.InsertOne(JSDev);
            Console.WriteLine("Document inserted.");
        }
    }
}

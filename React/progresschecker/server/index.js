const express = require("express");
const { MongoClient } = require("mongodb");
const cors = require("cors"); // Require CORS
const app = express();
app.use(cors()); // Use CORS
const port = 3003; // You can use any port that is free on your machine

app.get("/events", async (req, res) => {
  const client = new MongoClient("mongodb://localhost:27017");
  await client.connect();
  const database = client.db("ProgressTracker");
  const collection = database.collection("TasksInfo");
  const events = await collection.find({}).toArray();
  res.json(events);
  await client.close();
});

app.listen(port, () => {
  console.log(`Server listening at http://localhost:${port}`);
});

using DataAccess.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DBConnector : IDBConnector
    {
        #region Private Members
        private readonly IMongoDatabase _database;
        private readonly MongoClient client;
        private readonly IMongoCollection<Topic> _Topics;
        #endregion

        #region Constructor
        public DBConnector()
        {
            client = new MongoClient(Helper.ConnectionString);
            _database = client.GetDatabase("resourceDB");
            _Topics = _database.GetCollection<Topic>("TopicsColl");
        }
        #endregion

        #region Public Members
        public async Task InsertAsync<T>(string collectionName, T document)
        {
            var collection = _database.GetCollection<T>(collectionName);
            await collection.InsertOneAsync(document);
        }
        public void Insert<T>(string collectionName, T document)
        {
            var collection = _database.GetCollection<T>(collectionName);
            collection.InsertOne(document);
        }
        public List<T> Find<T>(string collectionName, FilterDefinition<T> filter)
        {
            var collection = _database.GetCollection<T>(collectionName);
            return collection.Find(filter).ToList();
        }
        public async Task<List<T>> FindAsync<T>(string collectionName, string fieldName, string value)
        {
            var collection = _database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq(fieldName, value);
            return await collection.Find(filter).ToListAsync();
        }
        public List<T> Find<T>(string collectionName, string fieldName, string value)
        {
            try
            {
                var collection = _database.GetCollection<T>(collectionName);
                //var listC = collection.Find(new BsonDocument()).ToList();
                var filter = Builders<T>.Filter.Eq(fieldName, value);
                return collection.Find(filter).ToList();
            }
            catch (Exception ex)
            {

            }
            return null;
        }
        public List<T> GetAllDocuments<T>(string collectionName)
        {
            var collection = _database.GetCollection<T>(collectionName);
            return collection.Find(new BsonDocument()).ToList();
        }
        public List<BsonDocument> GetCollection()
        {
            return _database.ListCollections().ToList();
        }
        public List<T> GetDocuments<T>(string collectionName, int skip, int limit)
        {
            return _database.GetCollection<T>(collectionName).Find(_ => true)
                              .Skip(skip)
                              .Limit(limit)
                              .ToList();
        }
        public void Update<T>(string collectionName, FilterDefinition<T> filter, UpdateDefinition<T> update)
        {
            var collection = _database.GetCollection<T>(collectionName);
            collection.UpdateOne(filter, update);
        }
        public void Delete<T>(string collectionName, FilterDefinition<T> filter)
        {
            var collection = _database.GetCollection<T>(collectionName);
            collection.DeleteOne(filter);
        }
        public long GetDocumentCount(string collectionName)
        {
            return _database.GetCollection<BsonDocument>(collectionName).CountDocuments(_ => true);
        }
        public void AddFieldToDocument<T>(string collectionName, FilterDefinition<T> filter, string fieldName, BsonValue fieldValue)
        {
            var collection = _database.GetCollection<T>(collectionName);
            var update = Builders<T>.Update.Set(fieldName, fieldValue);
            collection.UpdateOne(filter, update);
        }
        public List<string> GetIDs(string collectionName)
        {
            var projection = Builders<BsonDocument>.Projection.Include("_id");
            var documents = _database.GetCollection<BsonDocument>(collectionName).Find(new BsonDocument()).Project(projection).ToList();
            List<string> ids = new List<string>();
            foreach (var doc in documents)
            {
                ids.Add(doc["_id"].AsString);
            }

            return ids;
        }

        #endregion

        public async Task UpdateQuestionAsync(ObjectId topicId, ObjectId sectionId, string questionText, string answers)
        {
            try
            {
                Topic topic = await _Topics.Find(q => q.TopicId == topicId).FirstOrDefaultAsync();
                // If the questionnaire exists, check if the section exists.
                var section = topic.sections.FirstOrDefault(s => s.SectionId == sectionId);
                // If the section exists, add the question to it.
                var update = Builders<Topic>.Update.Push($"sections.$[s].questions", new Question { Ques = questionText, Answer = answers });
                var arrayFilters = new List<ArrayFilterDefinition> { new BsonDocumentArrayFilterDefinition<BsonDocument>(new BsonDocument("s.SectionName", sectionId)) };
                var updateOptions = new UpdateOptions { ArrayFilters = arrayFilters };
                await _Topics.UpdateOneAsync(q => q.TopicId == topic.TopicId, update, updateOptions);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public async Task InsertQuestion_NewSection_Async(ObjectId topicId, string sectionName, string questionText, string answers)
        {
            try
            {
                Topic topic = await _Topics.Find(q => q.TopicId == topicId).FirstOrDefaultAsync();
                // If the section doesn't exist, add it to the questionnaire.
                var update = Builders<Topic>.Update.Push(q => q.sections, new Section
                {
                    SectionName = sectionName,
                    questions = new List<Question> { new Question { Ques = questionText, Answer = answers } }
                });
                await _Topics.UpdateOneAsync(q => q.TopicId == topicId, update);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task InsertQuestion_New(string topicName, string sectionName, string questionText, string answers)
        {
            try
            {
                // Create a new questionnaire with the topic, section, and question.
                var topic = new Topic
                {
                    TopicName = topicName,
                    sections = new List<Section>
            {
                new Section
                {
                    SectionName = sectionName,
                    questions = new List<Question>
                    {
                        new Question { Ques = questionText, Answer = answers }
                    }
                }
            }
                };
                await _Topics.InsertOneAsync(topic);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

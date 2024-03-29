using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDBConnector
    {
        public Task InsertQuestion_NewSection_Async(ObjectId topicId, string sectionName, string questionText, string answers);
        public Task InsertQuestion_New(string topicName, string sectionName, string questionText, string answers);
        public Task UpdateQuestionAsync(ObjectId topicId, ObjectId sectionId, string questionText, string answers);
    }
}

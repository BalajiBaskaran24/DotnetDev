using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Question
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId QuestionId { get; set; } = ObjectId.GenerateNewId(); // Generate new Id
        public string Ques;
        public string Answer;

        //TODO:: Add provision to attach set of images
        //TODO:: Add provision to attach set of URLs
    }
}

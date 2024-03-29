using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Topic
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId TopicId { get; set; } = ObjectId.GenerateNewId(); // Generate new Id
        public List<Section> sections;
        public string TopicName;
    }
}

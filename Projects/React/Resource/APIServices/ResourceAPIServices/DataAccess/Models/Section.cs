using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Section
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId SectionId { get; set; } = ObjectId.GenerateNewId(); // Generate new Id
        public List<Question> questions = new List<Question>();
        public string SectionName;
    }
}

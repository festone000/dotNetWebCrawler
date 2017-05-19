using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ConfigConsole
{

    public class Developer
    {
        [BsonId]
        public ObjectId ID { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("company_name")]
        public string CompanyName { get; set; }
        [BsonElement("knowledge_base")]
        public List<Knowledge> KnowledgeBase { get; set; }
    }

    public class Knowledge
    {
        [BsonElement("langu_name")]
        public string Language { get; set; }
        [BsonElement("technology")]
        public string Technology { get; set; }
        [BsonElement("rating")]
        public ushort Rating { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("192.168.31.250");
            var db = client.GetDatabase("admin");
            
        }
    }
}

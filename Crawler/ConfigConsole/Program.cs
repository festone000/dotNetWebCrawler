using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ConfigConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Query();
        }

        public static void Query()
        {
            MongoClient client = new MongoClient("mongodb://192.168.31.243:27017");
            var database = client.GetDatabase("zsDatabase");
            var collection = database.GetCollection<BsonDocument>("zsCollection");

            collection.InsertOne(new BsonDocument("Name", "Jack"));
            
            var list = collection.Find(new BsonDocument("Name", "Jack")).ToList();

            foreach (var document in list)
            {
                Console.WriteLine(document["Name"]);
            }

        }
    }
}

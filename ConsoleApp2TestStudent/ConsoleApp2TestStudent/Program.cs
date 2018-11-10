using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ConsoleApp2TestStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("teststudent");

            var collection = database.GetCollection<BsonDocument>("student");
            Console.WriteLine("Data from Mongodb DATABASE");
            collection.Find(new BsonDocument()).ForEachAsync(X => Console.WriteLine(X));
            Console.Read();
        }
    }
}

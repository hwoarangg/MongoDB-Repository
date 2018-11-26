using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBTest
{
    public class EntityBase
    {
        [BsonId]
        public string Id { get; set; }
    }
}

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBT_Automation.Data.Models
{
    public class QueryModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int Priority { get; set; }
        public List<string> QueryText { get; set; } = new();
        public string Endpoint { get; set; }
        public string BaseURL { get; set; }
        public string Method { get; set; }
        public Dictionary<string, string> Headers { get; set; } = new();
        public Dictionary<string, object> Body { get; set; } = new();
        public List<QueryModel>? MethodList { get; set; } = new();
    }
}

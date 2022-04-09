using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ScheduleControlTemplate.Data.Entities
{
    public class TransactionLog
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("timestamp")]
        public DateTime Timestamp { get; set; }


        [BsonElement("userGuid")]
        public string UserGuid { get; set; }

        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("department")]
        public string Department { get; set; }


        [BsonElement("transactionType")]
        public string TransactionType { get; set; }

        [BsonElement("transactionResult")]
        public string TransactionResult { get; set; }

        [BsonElement("deviceName")]
        public string DeviceName { get; set; }
    }
}

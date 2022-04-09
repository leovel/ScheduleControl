using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ScheduleControlTemplate.Data.Entities
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("active")]
        public bool Active { get; set; }

        [BsonElement("userID")]
        public string UserID { get; set; }

        [BsonElement("department")]
        public string Department { get; set; }

        [BsonElement("emailAddr")]
        public string EmailAddr { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("phoneNum")]
        public string PhoneNum { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }
    }
}

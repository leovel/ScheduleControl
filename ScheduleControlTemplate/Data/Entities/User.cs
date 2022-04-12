using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ScheduleControlTemplate.Data.Entities
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("active")]
        public bool Active { get; set; }

        [BsonElement("adminID")]
        public string AdminID { get; set; }

        [BsonElement("adminPassword")]
        public string AdminPassword { get; set; }

        [BsonElement("authData")]
        public AuthData[] AuthData { get; set; }

        [BsonElement("cards")]
        public object[] Cards { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("createdVia")]
        public string CreatedVia { get; set; }

        [BsonElement("department")]
        public string Department { get; set; }

        [BsonElement("emailAddr")]
        public string EmailAddr { get; set; }

        [BsonElement("faceCode")]
        public string FaceCode { get; set; }

        [BsonElement("faceImg")]
        public string FaceImg { get; set; }

        [BsonElement("faceSmallImg")]
        public string FaceSmallImg { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("isAdmin")]
        public bool IsAdmin { get; set; }

        [BsonElement("isPasswordChangeRequired")]
        public bool IsPasswordChangeRequired { get; set; }

        [BsonElement("lIrisCode")]
        public string LIrisCode { get; set; }

        [BsonElement("lIrisImg")]
        public string LIrisImg { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("login")]
        public string Login { get; set; }

        [BsonElement("phoneNum")]
        public string PhoneNum { get; set; }

        [BsonElement("queryString")]
        public string QueryString { get; set; }

        [BsonElement("rIrisCode")]
        public string RIrisCode { get; set; }

        [BsonElement("rIrisImg")]
        public string RIrisImg { get; set; }

        [BsonElement("recogMode")]
        public string RecogMode { get; set; }

        [BsonElement("role")]
        public string Role { get; set; }

        [BsonElement("serialNumber")]
        public string SerialNumber { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [BsonElement("userDefined1")]
        public string UserDefined1 { get; set; }

        [BsonElement("userDefined2")]
        public string UserDefined2 { get; set; }

        [BsonElement("userDefined3")]
        public string UserDefined3 { get; set; }

        [BsonElement("userDefined4")]
        public string UserDefined4 { get; set; }

        [BsonElement("userDefined5")]
        public string UserDefined5 { get; set; }

        [BsonElement("userID")]
        public string UserID { get; set; }
    }

    public class AuthData
    {

        [BsonElement("authType")]
        public string AuthType { get; set; }

        [BsonElement("value")]
        public string Value { get; set; }
    }

    public class UserProjection
    {
        public string Id { get; set; }
        public string Department { get; set; }
        public string FullName { get; set; }
    }
}

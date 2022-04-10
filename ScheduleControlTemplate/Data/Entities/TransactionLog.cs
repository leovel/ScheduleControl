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

        [BsonElement("userDefined3")]
        public string UserDefined3 { get; set; }

        [BsonElement("userGuid")]
        public string UserGuid { get; set; }

        [BsonElement("userDefined5")]
        public string UserDefined5 { get; set; }

        [BsonElement("userDefined4")]
        public string UserDefined4 { get; set; }

        [BsonElement("transactionResult")]
        public string TransactionResult { get; set; }

        [BsonElement("pin")]
        public string Pin { get; set; }

        [BsonElement("matchedEye")]
        public string MatchedEye { get; set; }

        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }

        [BsonElement("auditFaceImg")]
        public string AuditFaceImg { get; set; }

        [BsonElement("FusionScore")]
        public double FusionScore { get; set; }

        [BsonElement("verifiedCard")]
        public VerifiedCard VerifiedCard { get; set; }

        [BsonElement("userDefined2")]
        public string UserDefined2 { get; set; }

        [BsonElement("deviceGuid")]
        public string DeviceGuid { get; set; }

        [BsonElement("deviceName")]
        public string DeviceName { get; set; }

        [BsonElement("IrisScore")]
        public double IrisScore { get; set; }

        [BsonElement("guid")]
        public string Guid { get; set; }

        [BsonElement("userDefined1")]
        public string UserDefined1 { get; set; }

        [BsonElement("FaceScore")]
        public double FaceScore { get; set; }

        [BsonElement("transactionType")]
        public string TransactionType { get; set; }

        [BsonElement("timestamp")]
        public DateTime Timestamp { get; set; }

        [BsonElement("transactionId")]
        public int TransactionId { get; set; }

        [BsonElement("elapsedTime")]
        public double ElapsedTime { get; set; }

        [BsonElement("deviceSn")]
        public string DeviceSn { get; set; }

        [BsonElement("role")]
        public string Role { get; set; }

        [BsonElement("recogMode")]
        public string RecogMode { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("department")]
        public string Department { get; set; }

        [BsonElement("ipd")]
        public double Ipd { get; set; }

        [BsonElement("userId")]
        public string UserId { get; set; }

        [BsonElement("userTemperature")]
        public int UserTemperature { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("verifiedBy")]
        public string VerifiedBy { get; set; }
    }

    public class VerifiedCard
    {

        [BsonElement("formatID")]
        public string FormatID { get; set; }
    }
}

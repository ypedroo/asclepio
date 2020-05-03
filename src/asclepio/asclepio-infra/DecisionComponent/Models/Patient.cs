using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace asclepio.infra.DecisionComponent.Models
{
    public class Patient
    {
        [BsonId]
        public ObjectId Id {get;set;}
        [BsonElement("firstname")]
        public string FirstName { get; set; }
        [BsonElement("lastname")]
        public string LastName { get; set; }
        [BsonElement("angle")]
        public decimal AngleTilted { get; set; }
        [BsonElement("isdizzy")]
        public bool IsDizzy { get; set; }
        [BsonElement("emergencyContact")]
        public string EmergencyContact { get; set; }
        [BsonElement("doctor")]
        public string DoctorName { get; set; }
        [BsonElement("shouldCallEmergency")]
        public bool ShouldCallEmergency { get; set; }
    }
}

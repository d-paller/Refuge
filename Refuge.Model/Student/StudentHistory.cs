using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Refuge.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Model.Student
{
    public class StudentHistory
    {
        public StudentHistory() { }

        public StudentHistory(HistoryEvent e, string studentId)
        {
            StudentId = studentId;
            TimeOfEvent = DateTime.Now;
            Event = e;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string StudentHistoryId { get; set; }

        public string StudentId { get; set; }

        public HistoryEvent Event { get; set; }

        public DateTime TimeOfEvent { get; set; }


    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Refuge.Model.Classes
{
    public class Class
    {
        [BsonId]
        public BsonObjectId ClassId { get; set; }

        public int TeacherUserId { get; set; }

        public string TeacherName { get; set; }

        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public string Location { get; set; }

        public DayOfWeek DayOfWeek { get; set; }
    }
}

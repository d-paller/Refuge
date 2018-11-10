using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Model
{
    public class DbClass : Class
    {
        [BsonId]
        public ObjectId Id { get; set; }

    }
}

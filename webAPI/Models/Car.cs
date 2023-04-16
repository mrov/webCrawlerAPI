using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace webAPI.Models
{
    public class Car
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        public string announceName { get; set; }
        public string formattedPrice { get; set; }
        public double price { get; set; }
        public string kilometer { get; set; }
        public string year { get; set; }
        public string shiftType { get; set; }
        public string gasType { get; set; }
        public string link { get; set; }
        public string img { get; set; }
        public string location { get; set; }
        public DateTime postDate { get; set; }
        public DateTime created { get; set; }

    }
}

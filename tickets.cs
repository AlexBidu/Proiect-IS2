using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MobyLab.Ticketing.Entities
{
    public partial class tickets
    {
        // Explicitly define the _id field, even if you don't use it in your business logic.
        [BsonId]  // Tells MongoDB to use this property as the _id field
        public string Id { get; set; }  // MongoDB's default ObjectId for the _id field


        public string Users { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Ticket { get; set; } = null!;
        
    }
}
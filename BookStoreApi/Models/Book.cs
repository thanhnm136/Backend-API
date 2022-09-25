using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookStoreApi.Models;

public class Book
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")]
    [JsonPropertyName("Name")] // represent property name in the web API serialized JSON response.
                               // Name instead of BookName
    public string BookName { get; set; } = null!;

    [BsonElement("Price")]
    public decimal Price { get; set; }

    public string Category { get; set; } = null!;

    public string Author { get; set; } = null!;
}
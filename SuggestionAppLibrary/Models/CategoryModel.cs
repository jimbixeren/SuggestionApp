
namespace SuggestionAppLibrary.Models;


public class CategoryModel
{
    

    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    // Proberty
    public string Id { get; set; }
    public string CategoryName { get; set; }
    public string CategroyDescription { get; set; }
}

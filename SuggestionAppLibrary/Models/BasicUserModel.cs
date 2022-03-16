

namespace SuggestionAppLibrary.Models;
public class BasicUserModel
{

    // Mongo database
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]

    // property
    public string Id { get; set; }
    public string DisplayName { get; set; }
    // constructor
    public BasicUserModel()
    {

    }

    // constructor
    public BasicUserModel(UserModel user)
    {
        Id = user.Id;
        DisplayName = user.DisplayName; 
    }
}

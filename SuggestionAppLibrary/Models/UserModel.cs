

namespace SuggestionAppLibrary.Models;
public class UserModel
{

    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

    public string Id { get; set; }

    // til azure Identifire 
    public string ObjectIdentifire { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public string EmailAddress { get; set; }
    public List<SuggestionModel> AuthoredSuggestions { get; set; } = new();
    public List<SuggestionModel> VotedOnSuggestions { get; set; } = new();
   


}

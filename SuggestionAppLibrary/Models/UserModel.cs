

namespace SuggestionAppLibrary.Models;
public class UserModel
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]


    // property
    public string Id { get; set; }

    // til azure Identifire 
    public string ObjectIdentifire { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public string EmailAddress { get; set; }
    public List<BasicSuggestionModel> AuthoredSuggestions { get; set; } = new();
    public List<BasicSuggestionModel> VotedOnSuggestions { get; set; } = new();
   


}

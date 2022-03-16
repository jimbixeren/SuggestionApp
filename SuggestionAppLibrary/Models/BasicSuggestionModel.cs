
namespace SuggestionAppLibrary.Models;
public class BasicSuggestionModel
{
    // til mongo database
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]

    // property
    public string Id { get; set; }
    public string Title { get; set; }

    // Constructor
    public BasicSuggestionModel()
    {

    }
    // constructor hvor Id og Title bruges
    public BasicSuggestionModel(SuggestionModel suggestion)
    {
        Id = suggestion.Id;
        Title = suggestion.Suggestion;
    }
}

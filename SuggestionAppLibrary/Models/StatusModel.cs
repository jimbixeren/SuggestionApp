
namespace SuggestionAppLibrary.Models;
public class StatusModel
{

    // til mongo db
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    // proberty
    public string Id { get; set; }
    public string StatusName { get; set; }
    public string StatusDescription { get; set; }

    

}

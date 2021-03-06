
namespace SuggestionAppLibrary.Models;

public class SuggestionModel
{
    // Mongo database
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    // property
    public string Id { get; set; }
    public string  Suggestion { get; set; }
    public string  Description { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public  CategoryModel Category { get; set; }
    public BasicUserModel  Author { get; set; }

    // En anden form af en liste med unik vadier. Og new initaliserer listen
    public HashSet<string> UserVotes { get; set; } = new();
    public StatusModel SuggestionStatus { get; set; }
    public string OwnerNotes { get; set; }
    public bool ApprovedForRelease { get; set; } = false;
    public bool Archived { get; set; } = false;
    public bool Rejected { get; set; } =false;




}

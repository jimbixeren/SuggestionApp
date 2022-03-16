using MongoDB.Driver;

namespace SuggestionAppLibrary.DataAccess;

public interface IConfguration
{
    MongoClientSettings GetConnectionstring(string connectionId);
}
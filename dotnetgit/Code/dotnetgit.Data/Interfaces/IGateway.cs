using MongoDB.Driver;

namespace dotnetgit.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}

using DapperBaseRepositoryDemo.Models;

namespace DapperBaseRepositoryDemo.Repositories
{
    public class UserRepository : BaseRepository
    {
        public User GetByID(int id)
        {
            var cmd = "SELECT * FROM user WHERE ID = @userID";
            return QuerySingle<User>(cmd,  new { userID = id });

        }

        public List<User> GetAll()
        {
            return Query<User>("SELECT * FROM user");
        }

        public List<User> SearchByFirstName(string firstName)
        {
            var cmd = "SELECT * FROM user WHERE FirstName LIKE @firstName + '%'";
            return Query<User>(cmd, new { firstName = firstName });
        }
    }
}

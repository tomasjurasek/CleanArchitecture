using Template.Core.User;
using Template.Core.User.Entities;

namespace Template.Infrastructure.Database.Repositores
{
    public class UserRepository : IUserRepository
    {
        public void Insert(User user)
        {
            //SAVE TO DB.
            //USER IS NOT YOUR DB ENTITY IT IS YOUR DOMAIL MODEL
        }
    }
}

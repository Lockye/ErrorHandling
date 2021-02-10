using OneOf;
using OneOfApplicationCore.Model;

namespace OneOfApplicationCore.Service
{
    public class UserService : IUserService
    {
        public OneOf<User, NameTaken, NameNotValid> SaveUser(User user)
        {
            return user.Name switch
            {
                "Pera" => new NameTaken("Name taken"),
                "Djura" => new NameNotValid("Name not valid"),
                _ => user,
            };
        }
    }
}

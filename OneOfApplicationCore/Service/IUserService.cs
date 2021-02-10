using OneOfApplicationCore.Model;
using OneOf;

namespace OneOfApplicationCore.Service
{
    public interface IUserService
    {
        OneOf<User, NameTaken, NameNotValid> SaveUser(User user);
    }
}

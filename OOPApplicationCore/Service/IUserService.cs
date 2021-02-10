using OOPApplicationCore.Model;

namespace OOPApplicationCore.Service
{
    public interface IUserService
    {
       SaveUserResult SaveUser(User user);
    }
}

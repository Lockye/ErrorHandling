using OOPApplicationCore.Model;

namespace OOPApplicationCore.Service
{
    public class UserService : IUserService
    {
        public SaveUserResult SaveUser(User user)
        {
            return user.Name switch
            {
                "Pera" => new NameTaken(),
                "Djura" => new NameNotValid(),
                _ => new CreateUserSuccess(user)
            };
        }
    }
}

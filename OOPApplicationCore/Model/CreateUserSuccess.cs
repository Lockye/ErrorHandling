namespace OOPApplicationCore.Model
{
    public class CreateUserSuccess : SaveUserResult
    {
        public CreateUserSuccess(User user) : base("User successfully created")
        {
            User = user;
        }

        public User User { get; set; }
    }
}

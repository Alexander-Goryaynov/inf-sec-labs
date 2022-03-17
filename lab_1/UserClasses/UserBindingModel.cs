namespace InfSec.User
{
    public class UserBindingModel
    {
        public string Login { set; get; }

        public string Password { set; get; }

        public bool Block { set; get; }

        public bool PasswordLimit { set; get; }

        public bool EnteringFirst { set; get; }
    }
}

namespace solid_demo
{
    interface IUser {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
        bool LogError(string error);
        bool SendEmail(string emailContent);
    }
}

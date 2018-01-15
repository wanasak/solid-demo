namespace solid_demo
{
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }
    interface ILogger
    {
        bool LogError(string error);
    }
    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}

namespace TokenWebAPI
{
    public interface ITokenManager
    {
        string Autheticate(string userName, string password);
    }
}

namespace TokenWebAPI.Bussiness
{
    public interface ITokenManager
    {
        string Autheticate(string userName, string password);
    }
}

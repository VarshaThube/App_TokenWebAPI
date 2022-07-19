namespace TokenWebAPI
{
    public class UserData
    {
        /// <summary>
        /// It returns List of Users with their UserName, Password (UserCredentials) in Dictionary
        /// </summary>
        public static Dictionary<string, string> User = new Dictionary<string, string>
        {
            {"test-user","test1234" }
        };
    }
}

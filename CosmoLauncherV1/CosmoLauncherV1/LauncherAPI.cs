namespace CosmoLauncherV1
{
    public static class LauncherAPI
    {
        public static bool Login(string username, string password)
        {
            // TODO: Replace with actual backend API logic
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            return username == "test" && password == "1234"; // Example only
        }
    }
}

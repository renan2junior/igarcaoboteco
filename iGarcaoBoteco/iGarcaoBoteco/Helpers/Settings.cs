// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace iGarcaoBoteco.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        const string UserIdKey = "userid";
        static readonly string UserIdDefault = string.Empty;

        const string AuthTokenKey = "authtoken";
        static readonly string AuthTokenDefault = string.Empty;


        public static string Authtoken
        {

            get { return AppSettings.GetValueOrDefault<string>(AuthTokenKey, AuthTokenDefault); }
            set { AppSettings.AddOrUpdateValue<string>(AuthTokenKey, value); }
        }

        public static string UserId
        {
            get { return AppSettings.GetValueOrDefault<string>(UserIdKey, UserIdDefault); }
            set { AppSettings.AddOrUpdateValue<string>(UserIdKey, value); }
        }

        public static bool IsLoggedIn
        {
            get { return !string.IsNullOrWhiteSpace(UserId); }
        }


    }
}
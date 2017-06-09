using System;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using iGarcaoBoteco.Helpers;
using iGarcaoBoteco;

[assembly: Dependency(typeof(AzureService))]
namespace iGarcaoBoteco
{
    public class AzureService
    {
        static readonly string AppUrl = "https://renan2juniormaratona.azurewebsites.net";

        public MobileServiceClient Client { get; set; } = null;

        public static bool UseAuth { get; set; } = false;

        public void Initialize()
        {
            Client = new MobileServiceClient(AppUrl);

            if (!string.IsNullOrWhiteSpace(Settings.Authtoken) && !string.IsNullOrWhiteSpace(Settings.UserId))
            {
                Client.CurrentUser = new MobileServiceUser(Settings.UserId)
                {
                    MobileServiceAuthenticationToken = Settings.Authtoken
                };
            }
        }

		public async Task Logout()
		{
			Initialize();
			await Client.LogoutAsync();
			Settings.Authtoken = string.Empty;
			Settings.UserId = string.Empty;
            var auth = DependencyService.Get<iAuthentication>();
			await auth.LogoutAsync(Client);
		}


        public async Task<MobileServiceUser> LoginAsync()
        {
            Initialize();

            var auth = DependencyService.Get<iAuthentication>();
            var user = await auth.LoginAsync(Client, MobileServiceAuthenticationProvider.Facebook);

            if (user == null)
            {
                Settings.Authtoken = string.Empty;
                Settings.UserId = string.Empty;

                Device.BeginInvokeOnMainThread(async () =>
                {
                    await App.Current.MainPage.DisplayAlert("Ops!", "Nao conseguimos efetuar o seu login!", "OK");
                });

                return null;
            }
            else
            {
                Settings.Authtoken = user.MobileServiceAuthenticationToken;
                Settings.UserId = user.UserId;
            }
            var userInfo = await Client.InvokeApiAsync("/.auth/me", System.Net.Http.HttpMethod.Get, null);
            return user;
        }
    }
}

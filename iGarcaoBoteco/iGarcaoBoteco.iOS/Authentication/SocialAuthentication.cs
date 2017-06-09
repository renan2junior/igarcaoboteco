using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iGarcaoBoteco.Helpers;
using iGarcaoBoteco.iOS;
using Microsoft.WindowsAzure.MobileServices;

[assembly: Xamarin.Forms.Dependency(typeof(SocialAuthentication))]
namespace iGarcaoBoteco.iOS
{
    public class SocialAuthentication : iAuthentication
    {

        public async Task<MobileServiceUser> LoginAsync(MobileServiceClient client, MobileServiceAuthenticationProvider provider, IDictionary<string, string> parameters = null)
        {
            try
            {
                var current = GetController();
                var user = await client.LoginAsync(current, provider);
                Settings.Authtoken = user?.MobileServiceAuthenticationToken ?? string.Empty;
                Settings.UserId = user?.UserId;
                return user;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task LogoutAsync(MobileServiceClient client, IDictionary<string, string> parameters = null)
        {
            try
            {
                //CookieManager.Instance.RemoveAllCookie();
                await client.LogoutAsync();
            }
            catch (Exception)
            {
                // TODO: Log error
                throw;
            }
        }


        private UIKit.UIViewController GetController()
        {
            var window = UIKit.UIApplication.SharedApplication.KeyWindow;
            var root = window.RootViewController;

            if (root == null) return null;

            var current = root;
            while (current.PresentedViewController != null)
            {
                current = current.PresentedViewController;
            }
            return current;
        }
    }
}

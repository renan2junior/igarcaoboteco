using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iGarcaoBoteco.Droid;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using iGarcaoBoteco.Helpers;
using Android.Webkit;

[assembly: Dependency(typeof(SocialAuthentication))]
namespace iGarcaoBoteco.Droid
{
	public class SocialAuthentication : iAuthentication
	{
		public async Task<MobileServiceUser> LoginAsync(MobileServiceClient client, MobileServiceAuthenticationProvider provider, IDictionary<string, string> parameters = null)
		{

			try
			{
				var user = await client.LoginAsync(Forms.Context, provider);
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
				CookieManager.Instance.RemoveAllCookie();
				await client.LogoutAsync();
			}
			catch (Exception)
			{
				// TODO: Log error
				throw;
			}
		}
    }
}

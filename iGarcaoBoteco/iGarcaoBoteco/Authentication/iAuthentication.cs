using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace iGarcaoBoteco
{
	public interface iAuthentication
	{
		Task<MobileServiceUser> LoginAsync(MobileServiceClient client,
								   MobileServiceAuthenticationProvider provider,
								   IDictionary<string, string> parameters = null);

        Task LogoutAsync(MobileServiceClient client, IDictionary<string, string> parameters = null);
	}
}

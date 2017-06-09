using Newtonsoft.Json;

namespace iGarcaoBoteco
{
	public class User
	{
		[JsonProperty("userId")]
		public string UserId
		{
			get;
			set;
		}

		[JsonProperty("first_name")]
		public string FirstName
		{
			get;
			set;
		}

	}
}

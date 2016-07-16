using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OGPortfolio
{
	public class OGApiRestService : OGIRestService
	{
		HttpClient client;

		public List<OGProjectItem> Items { get; private set; }

		public OGApiRestService()
		{
			client = new HttpClient();
		}

	

		public Task<List<OGProjectItem>> GetProjectPerUserAsynch(OGUserItem user)
		{
			throw new NotImplementedException();
		}

		public async Task<OGUserItem> GetUserAsync(String username)
		{

			//var uri = new Uri(string.Format("{0}/{1}?{2}={}",Constants.URL_BASE,Constants.API_PATH_USER,username,Constants.ClientID));

			var uri = new Uri(Constants.URL_BASE+"/"+Constants.API_PATH_USER+"/"+username+"?"+Constants.API_URL_VAR_CLIENT_ID+"="+Constants.ClientID);
			Debug.WriteLine("calling::: " + uri);

			OGUserItem userItem = new OGUserItem();

			try
			{
				//var json = JsonConvert.SerializeObject(username);
				//var content = new StringContent(json, Encoding.UTF8, "application/json");

				HttpResponseMessage response = null;


				response = await client.GetAsync(uri);

				if (response.IsSuccessStatusCode)
				{
					
					var user = JObject.Parse(response.Content.ReadAsStringAsync().Result);
					//Debug.WriteLine(@"GetProjectPerUserAsynch  loaded." + user["user"] );
					userItem = JsonConvert.DeserializeObject<OGUserItem>(""+user["user"]);

				}


			}
			catch (Exception ex)
			{
				Debug.WriteLine(@"				ERROR {0}", ex.Message);
			}


			return userItem;


		}

	}

}


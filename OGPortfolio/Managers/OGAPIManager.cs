using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace OGPortfolio
{
	public class OGAPIManager
	{
		OGIRestService restService;

		public OGAPIManager(OGIRestService service)
		{
			restService = service;
		}

	

		public Task<OGUserItem> GetUser(String userName)
		{
			return restService.GetUserAsync(userName);
		}
		


	}

}

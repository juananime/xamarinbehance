using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OGPortfolio
{
	public interface OGIRestService
	{
		//Task<List<OGProjectItem>> GetProjectPerUserAsynch(OGUserItem user);

		Task<OGUserItem> GetUserAsync(String username);

	}
}


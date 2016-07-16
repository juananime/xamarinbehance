using System;
using System.Collections.Generic;

namespace OGPortfolio
{
	public class OGUserItem
	{
		public OGUserItem()
		{
			
		}

		public int id { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string username { get; set; }
		public string occupation { get; set; }
		public Dictionary<string, string> images { get; set;}

	}
}


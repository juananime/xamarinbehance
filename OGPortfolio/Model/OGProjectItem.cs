using System;

namespace OGPortfolio 
{
	/// <summary>
	/// Todo Item business object
	/// </summary>
	public class OGProjectItem 
	{
		public OGProjectItem ()
		{
		}

        public int ID { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }	// TODO: add this field to the user-interface
	}
}
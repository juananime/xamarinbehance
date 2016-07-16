using Xamarin.Forms;
using System.Diagnostics;

namespace OGPortfolio
{
	public partial class OGPortfolioPage : ContentPage
	{
		public OGPortfolioPage()
		{
			InitializeComponent();
		}
		protected async override void OnAppearing()
		{
			base.OnAppearing();




			OGUserItem user = await App.ApiManager.GetUser("juananime");

			Debug.WriteLine("::::: " + user.images.ContainsKey("50"));
		}
	}
}


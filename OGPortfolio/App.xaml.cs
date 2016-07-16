using Xamarin.Forms;

namespace OGPortfolio
{
	public partial class App : Application
	{
		public static OGAPIManager ApiManager { get; private set; }
		public App()
		{
			InitializeComponent();


			MainPage = new OGPortfolioPage();
			ApiManager = new OGAPIManager(new OGApiRestService());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}


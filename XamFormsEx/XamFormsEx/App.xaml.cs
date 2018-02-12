
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamFormsEx
{
    public partial class App : Application
	{
        public int ScreenCount = 0;
		public App ()
		{
			InitializeComponent();

            //MainPage = new NavigationPage(new Pages.PagesHome());
            MainPage = new AppHome();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
